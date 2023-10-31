using PizzariaDoZe.Aplicacao.ModuloFuncionario;
using PizzariaDoZe.Aplicacao.ModuloSabor;
using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloEndereco;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using PizzariaDoZe.Dominio.ModuloSabor;
using PizzariaDoZe.ModuloFuncionario;
using PizzariaDoZe.ModuloIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.ModuloSabor {
    public class ControladorSabor : ControladorBase {

        private TabelaSaborControl tabela;

        private IRepositorioSabor repositorioSabor;
        private IRepositorioIngrediente repositorioIngrediente;

        private ServicoSabor servicoSabor;

        public ControladorSabor(IRepositorioSabor repositorioSabor, IRepositorioIngrediente repositorioIngrediente, ServicoSabor servicoSabor) {
            this.repositorioSabor = repositorioSabor;
            this.repositorioIngrediente = repositorioIngrediente;
            this.servicoSabor = servicoSabor;
        }

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
            TelaSaborForm tela = new TelaSaborForm(repositorioIngrediente);

            tela.onGravarRegistro += servicoSabor.Inserir;

            tela.ConfigurarSabor(new Sabor());

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK) {
                CarregarSabores();
            }
        }

        

        private void CarregarSabores() {
            List<Sabor> sabores = repositorioSabor.SelecionarTodos();

            tabela.AtualizarRegistros(sabores);

        }

        public override UserControl ObterListagem() {
            if(tabela== null) {
                tabela = new TabelaSaborControl();
            }

            CarregarSabores();
            return tabela;
        }

        public override string ObterTipoCadastro() {
            return "Cadastro de Sabores";
        }
    }
}
