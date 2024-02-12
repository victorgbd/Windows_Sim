namespace Windows_Sim
{
    partial class AdministradorDeTareas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorDeTareas));
            timerRecursos = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cpuModelLb = new Label();
            panelRecursos = new Panel();
            label4 = new Label();
            label3 = new Label();
            chartDisk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            diskLabel = new Label();
            chartRam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            panelProcesos = new Panel();
            dataGridView1 = new DataGridView();
            labelProcesos = new Label();
            labelRecursos = new Label();
            timerProcesos = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)chartCPU).BeginInit();
            panelRecursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDisk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRam).BeginInit();
            panelProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // timerRecursos
            // 
            timerRecursos.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 33);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "CPU";
            // 
            // chartCPU
            // 
            chartCPU.BorderSkin.BorderColor = Color.ForestGreen;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.Name = "ChartArea1";
            chartCPU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartCPU.Legends.Add(legend1);
            chartCPU.Location = new Point(84, 33);
            chartCPU.Name = "chartCPU";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartCPU.Series.Add(series1);
            chartCPU.Size = new Size(640, 163);
            chartCPU.TabIndex = 2;
            chartCPU.Text = "chart1";
            // 
            // cpuModelLb
            // 
            cpuModelLb.AutoSize = true;
            cpuModelLb.Location = new Point(431, 10);
            cpuModelLb.Name = "cpuModelLb";
            cpuModelLb.Size = new Size(29, 20);
            cpuModelLb.TabIndex = 6;
            cpuModelLb.Text = "     ";
            // 
            // panelRecursos
            // 
            panelRecursos.Controls.Add(label4);
            panelRecursos.Controls.Add(label3);
            panelRecursos.Controls.Add(chartDisk);
            panelRecursos.Controls.Add(diskLabel);
            panelRecursos.Controls.Add(chartRam);
            panelRecursos.Controls.Add(label1);
            panelRecursos.Controls.Add(label2);
            panelRecursos.Controls.Add(chartCPU);
            panelRecursos.Controls.Add(cpuModelLb);
            panelRecursos.Location = new Point(29, 57);
            panelRecursos.Name = "panelRecursos";
            panelRecursos.Size = new Size(759, 614);
            panelRecursos.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(632, 416);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 14;
            label4.Text = "Disk Usage";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(632, 210);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 13;
            label3.Text = "RAM Usage";
            // 
            // chartDisk
            // 
            chartDisk.BorderSkin.BorderColor = Color.ForestGreen;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.Name = "ChartArea1";
            chartDisk.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartDisk.Legends.Add(legend2);
            chartDisk.Location = new Point(84, 439);
            chartDisk.Name = "chartDisk";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartDisk.Series.Add(series2);
            chartDisk.Size = new Size(640, 169);
            chartDisk.TabIndex = 12;
            chartDisk.Text = "chart1";
            // 
            // diskLabel
            // 
            diskLabel.AutoSize = true;
            diskLabel.Location = new Point(0, 439);
            diskLabel.Name = "diskLabel";
            diskLabel.Size = new Size(37, 20);
            diskLabel.TabIndex = 11;
            diskLabel.Text = "Disk";
            // 
            // chartRam
            // 
            chartRam.BorderSkin.BorderColor = Color.ForestGreen;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.Name = "ChartArea1";
            chartRam.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartRam.Legends.Add(legend3);
            chartRam.Location = new Point(84, 233);
            chartRam.Name = "chartRam";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartRam.Series.Add(series3);
            chartRam.Size = new Size(640, 169);
            chartRam.TabIndex = 10;
            chartRam.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 233);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 9;
            label1.Text = "RAM";
            // 
            // panelProcesos
            // 
            panelProcesos.Controls.Add(dataGridView1);
            panelProcesos.Location = new Point(29, 57);
            panelProcesos.Name = "panelProcesos";
            panelProcesos.Size = new Size(759, 614);
            panelProcesos.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(751, 605);
            dataGridView1.TabIndex = 0;
            // 
            // labelProcesos
            // 
            labelProcesos.AutoSize = true;
            labelProcesos.Location = new Point(34, 21);
            labelProcesos.Name = "labelProcesos";
            labelProcesos.Size = new Size(67, 20);
            labelProcesos.TabIndex = 11;
            labelProcesos.Text = "Procesos";
            labelProcesos.Click += labelProcesos_Click;
            // 
            // labelRecursos
            // 
            labelRecursos.AutoSize = true;
            labelRecursos.Location = new Point(123, 21);
            labelRecursos.Name = "labelRecursos";
            labelRecursos.Size = new Size(67, 20);
            labelRecursos.TabIndex = 12;
            labelRecursos.Text = "Recursos";
            labelRecursos.Click += label6_Click;
            // 
            // timerProcesos
            // 
            timerProcesos.Tick += timerProcesos_Tick;
            // 
            // AdministradorDeTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 695);
            Controls.Add(labelRecursos);
            Controls.Add(labelProcesos);
            Controls.Add(panelProcesos);
            Controls.Add(panelRecursos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdministradorDeTareas";
            Text = "AdministradorDeTareas";
            Load += AdministradorDeTareas_Load;
            ((System.ComponentModel.ISupportInitialize)chartCPU).EndInit();
            panelRecursos.ResumeLayout(false);
            panelRecursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDisk).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRam).EndInit();
            panelProcesos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerRecursos;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private Label cpuModelLb;
        private Panel panelRecursos;
        private Label label4;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDisk;
        private Label diskLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRam;
        private Label label1;
        private Panel panelProcesos;
        private Label labelProcesos;
        private Label labelRecursos;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timerProcesos;
    }
}