using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Globalization;

namespace PizzariaDoZe {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
          

            AjustaIdiomaRegiao();
           
            ApplicationConfiguration.Initialize();

            Application.Run(new TelaPrincipalForm());


        }

        static public void AjustaIdiomaRegiao() {
            // ? indica que o valor pode ser nulo
            // no ternário estamos tratando para isso não acontecer
            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";
            // ajusta o idioma/região
            // o operador ! (null-forgiving) afirma que o valor já foi tratado e não será nulo aqui
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);
        }


    }
}