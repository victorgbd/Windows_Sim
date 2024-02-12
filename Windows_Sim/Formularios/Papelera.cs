using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Sim
{
    public partial class Papelera : Form
    {
        private string raiz = "papelera";
        string rutaCompleta = "";
        public Papelera()
        {
            InitializeComponent();
        }
        private async Task Initialized()
        {
            await webView21.EnsureCoreWebView2Async(null);
            bool exists = Directory.Exists(raiz); if (!exists) Directory.CreateDirectory(raiz);
            rutaCompleta = Path.Combine(Environment.CurrentDirectory, raiz);

        }
        private async void InitBrowser()
        {
            await Initialized();
            webView21.CoreWebView2.Navigate(rutaCompleta);
        }

        private void Papelera_Load(object sender, EventArgs e)
        {
            InitBrowser();

        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            
            Directory.Delete(raiz, true);
            bool exists = Directory.Exists(raiz); if (!exists) Directory.CreateDirectory(raiz);
            if (webView21 != null)
            {
                webView21.Reload();
            }
        }
    }
}
