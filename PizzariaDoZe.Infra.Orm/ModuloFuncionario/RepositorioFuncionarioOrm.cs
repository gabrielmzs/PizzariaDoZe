using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloFuncionario;
using PizzariaDoZe.Infra.Orm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.ModuloFuncionario {
    public class RepositorioFuncionarioOrm : RepositorioBaseORM<Funcionario>, IRepositorioFuncionario {
        public RepositorioFuncionarioOrm(PizzariaDoZeDbContext dbContext) : base(dbContext) {
        }

        //public void Inserir(Ingrediente ingrediente) {
        //    throw new NotImplementedException();
        //}

        public Funcionario SelecionarPorNome(string nome) {

            return registros.FirstOrDefault(x => x.Nome == nome);
        }

        public List<Funcionario> SelecionarTodos() {
            return registros.Include(x => x.Endereco).ToList();
        }
    }
}
