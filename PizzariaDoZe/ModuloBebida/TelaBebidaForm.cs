using FluentResults;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloBebida;

namespace PizzariaDoZe.ModuloBebida {
    public partial class TelaBebidaForm : Form {
        private Bebida bebida;
        public event GravarRegistroDelegate<Bebida> onGravarRegistro;
        

        public TelaBebidaForm() {
            
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            this.ConfigurarDialog();
            Funcoes.EventoFocoCampos(this);
            
        }

        

        public void ConfigurarBebida(Bebida bebida) {

            this.bebida = bebida;
            txtNome.Text = bebida.Nome;
            txtValor.Text = bebida.Valor.ToString();
            ConfigurarTamanho(bebida.Tamanho);
            ConfigurarTipo(bebida.Tipo);
            
        }


        public Bebida ObterBebida() {

            bebida.Nome = txtNome.Text;

            bebida.Valor = Convert.ToDecimal(txtValor.Text);

            bebida.Tamanho = ObterTamanho();

            bebida.Tipo = ObterTipo();

            return bebida;
        }

       

        private TipoBebidaEnum ObterTipo() {
            if (rbRefri.Checked == true) return TipoBebidaEnum.Refri;
            else if (rbCerveja.Checked == true) return TipoBebidaEnum.Cerveja;
            else if (rbSuco.Checked == true) return TipoBebidaEnum.Suco;
            else if (rbAgua.Checked == true) return TipoBebidaEnum.Água;
            else return TipoBebidaEnum.Outros;
        }

        private TamanhoBebidaEnum ObterTamanho() {
            if (label150.Checked == true) return TamanhoBebidaEnum.ml150;
            else if (label350.Checked == true) return TamanhoBebidaEnum.ml350;
            else if (label500.Checked == true) return TamanhoBebidaEnum.ml500;
            else if (label600.Checked == true) return TamanhoBebidaEnum.ml600;
            else if (label1.Checked == true) return TamanhoBebidaEnum.litro1;
            else if (label15.Checked == true) return TamanhoBebidaEnum.litro15;
            else  return TamanhoBebidaEnum.litro2;
        }

        private void ConfigurarTipo(TipoBebidaEnum tipo) {
            if (tipo == TipoBebidaEnum.Refri) rbRefri.Checked = true;
            else if(tipo == TipoBebidaEnum.Cerveja) rbCerveja.Checked = true;
            else if(tipo == TipoBebidaEnum.Suco) rbSuco.Checked = true;
            else if(tipo == TipoBebidaEnum.Água) rbAgua.Checked = true;
            else rbSuco.Checked = true;
        }


        private void ConfigurarTamanho(TamanhoBebidaEnum tamanho) {
            if (tamanho == TamanhoBebidaEnum.ml150) label150.Checked = true;
            else if(tamanho == TamanhoBebidaEnum.ml350) label350.Checked = true;
            else if(tamanho == TamanhoBebidaEnum.ml500) label500.Checked = true;
            else if(tamanho == TamanhoBebidaEnum.ml600) label600.Checked = true;
            else if(tamanho == TamanhoBebidaEnum.litro1) label1.Checked = true;
            else if(tamanho == TamanhoBebidaEnum.litro15) label15.Checked = true;
            else  label2.Checked = true;
        }
       

       

        private void btnSalvar_Click(object sender, EventArgs e) {
            bebida = ObterBebida();

            Result resultado = onGravarRegistro(bebida);

            if (resultado.IsFailed) {
                string erro = resultado.Errors[0].Message;

                MessageBox.Show(erro,"Falha",MessageBoxButtons.OK, MessageBoxIcon.Error);

                //TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }


}

