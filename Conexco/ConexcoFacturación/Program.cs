using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ConexcoFacturación
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.CurrentCulture = new CultureInfo("es-AR");
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("es-AR");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-AR");
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MdiConexco());
        }
    }
}
