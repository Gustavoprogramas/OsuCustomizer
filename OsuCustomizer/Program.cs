using System;
using System.Windows.Forms;

namespace OsuCustomizer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"erro fatal ao iniciar:\n\n{ex.Message}\n\nOnde ocorreu:\n{ex.StackTrace}",
                                "Crash no Startup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}