using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.Utilitarios;
using Design_Dashboard_Modern.Proveedor;

namespace Design_Dashboard_Modern
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
            Application.Run(new Menu());
            //Application.Run(new Form_Agregar_Productos());
        }
    }
}
