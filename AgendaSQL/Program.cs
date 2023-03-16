using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AgendaSQL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //inicia a aplicacao
            vars.Iniciar();

            //Abre o nosso formulario inicial
            Application.Run(new frmMenu());
        }
    }
}
