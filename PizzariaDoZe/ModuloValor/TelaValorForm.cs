using FluentResults;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloValor;

namespace PizzariaDoZe.ModuloValor {
    public partial class TelaValorForm : Form {

        private Valor valor;
        public event GravarRegistroDelegate<Valor> onGravarRegistro;
        public TelaValorForm() {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.ConfigurarDialog();
            Funcoes.EventoFocoCampos(this);
        }


        public Valor ObterValor() {
            valor.ValorPizza = Convert.ToDecimal(txtValor.Text);
            valor.ValorBorda = Convert.ToDecimal(txtValorBorda.Text);

            valor.Tamanho = ConfigurarTamanho();
            valor.Categoria = ConfigurarCategoria();

            return valor;
        }

        private CategoriaPizzaEnum ConfigurarCategoria() {
            if (rbEspecial.Checked == true) return CategoriaPizzaEnum.Especial;
            else return CategoriaPizzaEnum.Tradicional;
        }

        private TamanhoPizzaEnum ConfigurarTamanho() {
            if (rbPequena.Checked == true) return TamanhoPizzaEnum.Pequena;
            else if (rbMedia.Checked == true) return TamanhoPizzaEnum.Média;
            else if (rbGrande.Checked == true) return TamanhoPizzaEnum.Grande;
            else return TamanhoPizzaEnum.Família;
        }

        public void ConfigurarValor(Valor valor) {

            this.valor = valor;
            txtValor.Text = valor.ValorPizza.ToString();
            txtValorBorda.Text = valor.ValorBorda.ToString();
            ConfigurarTamanho(valor.Tamanho);
            ConfigurarCategoria(valor.Categoria);   
        
        }

        private void ConfigurarCategoria(CategoriaPizzaEnum categoria) {
            if(categoria == CategoriaPizzaEnum.Tradicional) rbTradicional.Checked = true;
            else rbEspecial.Checked = true;
        }

        private void ConfigurarTamanho(TamanhoPizzaEnum tamanho) {
            if(tamanho == TamanhoPizzaEnum.Pequena) rbPequena.Checked = true;
            else if (tamanho == TamanhoPizzaEnum.Média) rbMedia.Checked = true;
            else if (tamanho == TamanhoPizzaEnum.Grande) rbGrande.Checked = true;
            else rbFamilia.Checked = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            this.valor = ObterValor();

            Result resultado = onGravarRegistro(valor);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                MessageBox.Show(erro, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
