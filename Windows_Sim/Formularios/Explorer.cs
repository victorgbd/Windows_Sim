using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Diagnostics;

namespace Windows_Sim
{
    public partial class Explorer : Form
    {
        private string raiz = "raiz";
        string rutaCompleta = "";
        string basurero = "papelera";
        string rutaCompletaP = "";
        public Explorer()
        {
            InitializeComponent();
        }
        private async Task Initialized()
        {
            await webView21.EnsureCoreWebView2Async(null);
            bool exists = Directory.Exists(raiz); if (!exists) Directory.CreateDirectory(raiz);
            rutaCompleta = Path.Combine(Environment.CurrentDirectory, raiz);
            exists = Directory.Exists(basurero); if (!exists) Directory.CreateDirectory(basurero);
            rutaCompletaP = Path.Combine(Environment.CurrentDirectory, basurero);

        }
        private async void InitBrowser()
        {
            await Initialized();
            webView21.CoreWebView2.Navigate(rutaCompleta);
        }

        private void Explorer_Load(object sender, EventArgs e)
        {
            InitBrowser();

        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string directorioNuevo = Path.Combine(rutaCompleta, textBox1.Text);
                bool exists = Directory.Exists(directorioNuevo); if (!exists) Directory.CreateDirectory(directorioNuevo);
                if (webView21 != null)
                {
                    webView21.Reload();
                }
            }

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog() { SelectedPath = rutaCompleta + "\\raiz", Description = "selecciona el folder a modificar" })
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        string directorioNuevo = Path.Combine(rutaCompleta, textBox1.Text);
                        Directory.Move(fbd.SelectedPath, directorioNuevo);
                    }
                }
                if (webView21 != null)
                {
                    webView21.Reload();
                }
            }

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { SelectedPath = rutaCompleta+"\\raiz", Description = "selecciona el folder a eliminar" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string destinoCompleto = Path.Combine(rutaCompletaP, Path.GetFileName(fbd.SelectedPath));
                    Directory.Move(fbd.SelectedPath, destinoCompleto);
                }
            }
            if (webView21 != null)
            {
                webView21.Reload();
            }
        }
    }
}
