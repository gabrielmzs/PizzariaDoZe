using PizzariaDoZe.Aplicacao.ModuloEndereco;
using PizzariaDoZe.Aplicacao.ModuloIngrediente;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.ModuloEndereco {
    public class ControladorEndereco:ControladorBase {

        private IRepositorioEndereco repositorioEndereco;
        private TabelaEnderecoControl tabelaEndereco;
        private ServicoEndereco servicoEndereco;


        public ControladorEndereco(IRepositorioEndereco repositorioEndereco, ServicoEndereco servicoEndereco) {
            this.repositorioEndereco = repositorioEndereco;
            this.servicoEndereco = servicoEndereco;
        }

        public override string ToolTipInserir { get { return "Inserir novo Endereço"; } }

        public override string ToolTipEditar { get { return "Editar Endereço existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Endereço existente"; } }

        public override void Editar() {
            throw new NotImplementedException();
        }

        public override void Excluir() {
            throw new NotImplementedException();
        }

        public override void Inserir() {
            TelaEnderecoForm tela = new TelaEnderecoForm();

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                MessageBox.Show("Endereço Cadastrado com sucesso!");
            }
            
        }

        

        public override UserControl ObterListagem() {
            if (tabelaEndereco == null)
                tabelaEndereco = new TabelaEnderecoControl();

            CarregarEnderecos();

            return tabelaEndereco;
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Endereços";
        }

        private void CarregarEnderecos() {
            List<Endereco> enderecos = repositorioEndereco.SelecionarTodos();

            tabelaEndereco.AtualizarRegistros(enderecos);

            //mensagemRodape = string.Format("Visualizando {0} parceiro{1}", parceiros.Count, parceiros.Count == 1 ? "" : "s");

            //TelaPrincipalForm.Instancia.AtualizarRodape(mensagemRodape);
        }

    }
}
