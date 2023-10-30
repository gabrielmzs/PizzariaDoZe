using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Compartilhado {
    public partial class TelaConfiguracaoForm : Form {
        public TelaConfiguracaoForm() {
            InitializeComponent();
            this.ConfigurarDialog();

            Funcoes.AjustaResourcesControl(this);
            Text = Properties.Resources.ResourceManager.GetString("txtTituloPrincipal");
            //seleciona no comboBox o idioma/cultura atual
            cmbIdiomas.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", cmbIdiomas.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            //atualiza a cultura corrente
            Program.AjustaIdiomaRegiao();
            Close();
            EnviarMensagem(cmbIdiomas.Text);
            
        }

        private void EnviarMensagem(string text) {
            if(text == "pt-BR")  MessageBox.Show("Idioma/região alterada com sucesso!");
            else if(text == "en-US")  MessageBox.Show("Language/region changed successfully!");
            else if(text == "es-ES")  MessageBox.Show("¡El idioma/región se cambió correctamente!");
        }
    }
}
