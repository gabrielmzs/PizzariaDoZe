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
            // no tern�rio estamos tratando para isso n�o acontecer
            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";
            // ajusta o idioma/regi�o
            // o operador ! (null-forgiving) afirma que o valor j� foi tratado e n�o ser� nulo aqui
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);
        }


    }
}