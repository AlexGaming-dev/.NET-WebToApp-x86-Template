using System;
using System.Windows.Forms;

namespace WebToApp {
    static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}
