using System;
using System.Windows.Forms;
using DrugstoreOrders.Forms;

namespace DrugstoreOrders
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Asegúrate de que esto apunta a tu formulario principal
        }
    }
}
