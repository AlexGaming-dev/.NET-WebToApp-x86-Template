using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;

namespace WebToApp {
    public partial class MainWindow : Form {
        private WebView2 webView;

        public MainWindow() {
            this.Text = "Alex Studios - WebToApp Desktop";
            this.Size = new Size(1280, 720);
            this.StartPosition = FormStartPosition.CenterScreen;

            webView = new WebView2 { Dock = DockStyle.Fill };
            this.Controls.Add(webView);
            InitializeAsync();
        }

        async void InitializeAsync() {
            try {
                // Initialisiert die Chromium-Engine
                await webView.EnsureCoreWebView2Async(null);
                // Deine Ziel-Seite
                webView.CoreWebView2.Navigate("https://alexgaming.netlify.app");
            } catch (Exception ex) {
                MessageBox.Show("Fehler beim Starten der WebView2-Engine: " + ex.Message, 
                                "Kritischer Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
