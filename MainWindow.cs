using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace WebToApp.Template
{
    public partial class MainWindow : Form
    {
        private WebView2 webView = new WebView2();

        public MainWindow()
        {
            this.Text = "WebToApp Template - Alex Studios";
            this.Size = new System.Drawing.Size(1280, 720);
            webView.Dock = DockStyle.Fill;
            this.Controls.Add(webView);
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            await webView.EnsureCoreWebView2Async(null);
            // PLATZHALTER: Hier die Ziel-URL eintragen
            webView.CoreWebView2.Navigate("https://alexgaming.netlify.app");
        }

        [STAThread]
        static void Main() {
            Application.Run(new MainWindow());
        }
    }
}
