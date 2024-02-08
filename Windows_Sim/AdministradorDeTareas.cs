using Hardware.Info;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Windows_Sim
{
    public partial class AdministradorDeTareas : Form
    {
        protected PerformanceCounter cpuCounter;
        protected PerformanceCounter diskCounter;
        double x;
        Computer computerInfo;
        IHardwareInfo hardwareInfo;
        List<Panel> panels;
        protected Process[] processCollection = Process.GetProcesses();

        public AdministradorDeTareas()
        {
            InitializeComponent();
            hardwareInfo = new HardwareInfo();
            panels = new List<Panel>();
            panels.Add((panelProcesos));
            panels.Add(panelRecursos);

            computerInfo = new Computer();

            chartCPU.Series[0].ChartType = SeriesChartType.SplineArea;
            chartRam.Series[0].ChartType = SeriesChartType.Area;
            chartDisk.Series[0].ChartType = SeriesChartType.Area;
            cpuCounter = new PerformanceCounter();

            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            //ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            diskCounter =
            new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");


            timerProcesos.Interval = 10000;
            timerRecursos.Interval = 1000; // 1000 milisegundos = 1 segundo

            // Inicia el Timer
            timerRecursos.Start();
            timerProcesos.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //double ram = ramCounter.NextValue();
            if (hardwareInfo.CpuList.Count > 0)
            {
                cpuModelLb.Text = hardwareInfo.CpuList[0].Name;
            }
            else
            {
                cpuModelLb.Text = "";
            }

            double disk = diskCounter.NextValue();
            double cpuTotal = cpuCounter.NextValue();
            ulong totalMemoryBytes = computerInfo.Info.TotalPhysicalMemory;
            ulong availableMemoryBytes = computerInfo.Info.AvailablePhysicalMemory;
            double totalMemoryMB = totalMemoryBytes / 1048576.0;
            double availableMemoryMB = availableMemoryBytes / 1048576.0;
            double memoriaEnUso = totalMemoryMB - availableMemoryMB;


            label1.Text = memoriaEnUso.ToString("0") + "MB";
            label2.Text = cpuTotal.ToString("0.0") + "%";
            diskLabel.Text = disk.ToString("0.0") + "%";

            //CPU Chart
            chartCPU.Series[0].Points.AddXY(x, cpuTotal);
            if (chartCPU.Series[0].Points.Count > 10) chartCPU.Series[0].Points.RemoveAt(0);
            chartCPU.ChartAreas[0].AxisX.Minimum = chartCPU.Series[0].Points[0].XValue;
            chartCPU.ChartAreas[0].AxisX.Maximum = x;
            chartCPU.ChartAreas[0].AxisY.Maximum = 100.0;

            //RAM Chart
            chartRam.Series[0].Points.AddXY(x, memoriaEnUso);
            if (chartRam.Series[0].Points.Count > 10) chartRam.Series[0].Points.RemoveAt(0);
            chartRam.ChartAreas[0].AxisX.Minimum = chartRam.Series[0].Points[0].XValue;
            chartRam.ChartAreas[0].AxisX.Maximum = x;
            chartRam.ChartAreas[0].AxisY.Maximum = totalMemoryMB;

            //Disk Chart
            chartDisk.Series[0].Points.AddXY(x, disk);
            if (chartDisk.Series[0].Points.Count > 10) chartDisk.Series[0].Points.RemoveAt(0);
            chartDisk.ChartAreas[0].AxisX.Minimum = chartDisk.Series[0].Points[0].XValue;
            chartDisk.ChartAreas[0].AxisX.Maximum = x;
            chartDisk.ChartAreas[0].AxisY.Maximum = 100.0;
            x += 1;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panels[1].BringToFront();
        }

        private void labelProcesos_Click(object sender, EventArgs e)
        {
            panels[0].BringToFront();
        }

        private void AdministradorDeTareas_Load(object sender, EventArgs e)
        {
            List<DataCPUProcesos> listaProcesos = new List<DataCPUProcesos>();
            Task.Run(() => { hardwareInfo.RefreshCPUList(); });
            Task.Run(() => {
                
                foreach (Process process in processCollection)
                {
                    using (PerformanceCounter processCpuCounter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName))
                    {
                        float processCpuUsage = processCpuCounter.NextValue();
                        listaProcesos.Add(new DataCPUProcesos(process.ProcessName, processCpuUsage + "%"));

                    }
                }
            });
            dataGridView1.DataSource = listaProcesos;
        }

        private void timerProcesos_Tick(object sender, EventArgs e)
        {
                Task thread = new Task(procesosRun);
                thread.Start();
        }
        private void updateData(List<DataCPUProcesos> dataCPU)
        {
            
            dataGridView1.DataSource = dataCPU;
            
        }
        private void procesosRun()
        {
            List<DataCPUProcesos> listaProcesos = new List<DataCPUProcesos>();
            foreach (Process process in processCollection)
            {
                using (PerformanceCounter processCpuCounter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName))
                {
                    float processCpuUsage = processCpuCounter.NextValue();

                    listaProcesos.Add(new DataCPUProcesos(process.ProcessName, processCpuUsage + "%"));
                }
            }
            dataGridView1.Invoke((MethodInvoker)delegate
            {
                updateData(listaProcesos);
            });
        }
    }
}
