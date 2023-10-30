using FluentResults;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using System.Configuration;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloIngrediente {
    public partial class TelaIngredienteForm : Form {

        private Ingrediente ingrediente;

        public event GravarRegistroDelegate<Ingrediente> onGravarRegistro;


        public TelaIngredienteForm() {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.ConfigurarDialog();
            Funcoes.EventoFocoCampos(this);

            
        }

        public Ingrediente ObterIngrediente() {

            ingrediente.Nome = txtNome.Text;

            return ingrediente;
        }

        public void ConfigurarIngrediente(Ingrediente ingrediente) {

            this.ingrediente = ingrediente;
            txtNome.Text = ingrediente.Nome;
        }



        private void btnSalvar_Click(object sender, EventArgs e) {
            this.ingrediente = ObterIngrediente();

            Result resultado = onGravarRegistro(ingrediente);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                //TelaPrincipalForm.Instancia.AtualizarRodape(erro)

                DialogResult = DialogResult.None;
            }
        }
    }
}
