using System;
using System.Windows.Forms;

namespace GlossaryApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // konfigurasi startup winform modern
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
