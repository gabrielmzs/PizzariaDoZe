using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.ModuloIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.ModuloSabor {
    public class ControladorSabor : ControladorBase {

        private TabelaSaborControl tabela;
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
            TelaSaborForm tela = new TelaSaborForm();

            DialogResult opcaoEscolhida = tela.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK) {
                MessageBox.Show("Sabor Cadastrado com sucesso!");
            };
        }

        public override UserControl ObterListagem() {
            if(tabela== null) {
                tabela = new TabelaSaborControl();
            }
            return tabela;
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Sabores";
        }
    }
}
