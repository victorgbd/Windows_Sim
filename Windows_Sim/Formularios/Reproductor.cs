using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Sim.Formularios
{
    public partial class Reproductor : Form
    {
        bool play = false;
        string[] archivosMP3;
        string[] rutasArchivosMP3;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        public Reproductor()
        {
            
            InitializeComponent();
            vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)vlcControl1).BeginInit();
            vlcControl1.VlcLibDirectory = new DirectoryInfo("C:\\Program Files\\VideoLAN\\VLC");
            vlcControl1.BackColor = Color.Black;
            vlcControl1.Location = new Point(418, 85);
            vlcControl1.Name = "vlcControl1";
            vlcControl1.Size = new Size(370, 341);
            vlcControl1.Spu = -1;
            vlcControl1.TabIndex = 0;
            vlcControl1.Text = "vlcControl1";
            vlcControl1.VlcMediaplayerOptions = null;
            Controls.Add(vlcControl1);
            ((System.ComponentModel.ISupportInitialize)vlcControl1).EndInit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                vlcControl1.Play(new Uri(rutasArchivosMP3[listBox1.SelectedIndex]));

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    archivosMP3 = ofd.SafeFileNames;
                    rutasArchivosMP3 = ofd.FileNames;
                    foreach (var ArchivoMP3 in archivosMP3)
                    {
                        listBox1.Items.Add(ArchivoMP3);
                    }
                    vlcControl1.Play(new Uri(rutasArchivosMP3[0]));
                    listBox1.SelectedIndex = 0;
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vlcControl1.Play(new Uri(rutasArchivosMP3[listBox1.SelectedIndex]));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }
    }
}
