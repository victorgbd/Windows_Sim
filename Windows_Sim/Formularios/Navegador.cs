using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_Sim
{
    public partial class Navegador : Form
    {
        public Navegador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
        private async Task Initialized()
        {
            await webView.EnsureCoreWebView2Async(null);
        }
        private async void InitBrowser()
        {
            await Initialized();
            addressBar.Text = "https://www.google.com";
            webView.CoreWebView2.Navigate("https://www.google.com");
        }


        private void webView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            addressBar.Text = webView.Source.OriginalString;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (webView != null)
            {
                webView.Reload();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webView != null)
            {
                if (webView.CanGoForward) webView.GoForward();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webView != null)
            {
                if (webView.CanGoBack) webView.GoBack();
            }
        }
    }
}
