using System;
using System.Windows.Forms;
using System.Threading;
using Clinic.view;

namespace Clinic {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Splash splash = new Splash();
            splash.Show();

            splash.infoMessage("Carregando Clinic...");
            Application.DoEvents();
            Thread.Sleep(5000);
            splash.infoMessage("Carregando, aguarde um instante...");
            Application.DoEvents();
            Thread.Sleep(4000);
            splash.infoMessage("Bem-Vindo ao Clinic");
            Application.DoEvents();
            Thread.Sleep(3000);

            splash.Dispose();

            Application.Run(new Main());
        }
    }
}
