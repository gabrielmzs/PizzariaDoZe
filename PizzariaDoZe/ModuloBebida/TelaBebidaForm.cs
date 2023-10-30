using PizzariaDoZe.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloBebida {
    public partial class TelaBebidaForm : Form {
        public TelaBebidaForm() {
            
            InitializeComponent();
            this.ConfigurarDialog();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.EventoFocoCampos(this);

            //this.Text = Properties.Resources.TelaBebidaFormText;

        }

       
    }
}
