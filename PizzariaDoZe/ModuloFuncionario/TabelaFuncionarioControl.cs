using PizzariaDoZe.Compartilhado;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.ModuloFuncionario {
    public partial class TabelaFuncionarioControl : UserControl {
        public TabelaFuncionarioControl() {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas() {

            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "Id", FillWeight=15F, Visible = false },

                new DataGridViewTextBoxColumn { Name = "Nome", HeaderText = "Nome", FillWeight=60F },

                new DataGridViewTextBoxColumn { Name = "Grupo", HeaderText = "Grupo", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "Matrícula", HeaderText = "Matrícula", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "Senha", HeaderText = "Senha", FillWeight=100F },

                new DataGridViewTextBoxColumn { Name = "CPF", HeaderText = "CPF", FillWeight=20F },

                new DataGridViewTextBoxColumn { Name = "Telefone", HeaderText = "Telefone", FillWeight=20F }
            };
            return colunas;
        }

        public Guid ObtemIdSelecionado() {
            return grid.SelecionarId();
        }
        public void AtualizarRegistros(List<Funcionario> funcionarios) {
            grid.Rows.Clear();

            foreach (Funcionario f in funcionarios) {
              
                string cpfFormatado = FormatCpf(f.Cpf);

                string telefoneFormatado = FormatTelefone(f.Telefone);

                grid.Rows.Add(f.Id, f.Nome, f.GrupoFuncionario, f.Matricula,f.Senha, cpfFormatado, telefoneFormatado);
            }
        }

        private string FormatCpf(string cpf) {
            if (!string.IsNullOrEmpty(cpf) && cpf.Length == 11) {
                return string.Format("{0:000\\.000\\.000-00}", long.Parse(cpf));
            }
            return cpf; 
        }

        private string FormatTelefone(string telefone) {
            if (!string.IsNullOrEmpty(telefone)) {
                if (telefone.Length == 10) {
                    return string.Format("({0:00}) {1} {2:0000-0000}",
                        long.Parse(telefone.Substring(0, 2)),
                        telefone[2],
                        long.Parse(telefone.Substring(3, 7))
                    );
                } else if (telefone.Length == 11) {
                    return string.Format("({0:00}) {1} {2:0000-0000}",
                        long.Parse(telefone.Substring(0, 2)),
                        telefone[2],
                        long.Parse(telefone.Substring(3, 7))
                    );
                }
            }
            return telefone;
        }
    }
}
