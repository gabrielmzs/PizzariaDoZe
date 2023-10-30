using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.ModuloBebida {
    public class ControladorBebida : ControladorBase {

        private TabelaBebidaControl tabela;
        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Editar() {
            throw new NotImplementedException();
        }

        public override void Excluir() {
            throw new NotImplementedException();
        }

        public override void Inserir() {
            TelaBebidaForm tela = new TelaBebidaForm();

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                MessageBox.Show("Bebida Cadastrada com sucesso!");
            }
        }

        public override UserControl ObterListagem() {
            if(tabela== null) {
                tabela = new TabelaBebidaControl();
            }
            return tabela;
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Bebidas";
        }
    }
}

