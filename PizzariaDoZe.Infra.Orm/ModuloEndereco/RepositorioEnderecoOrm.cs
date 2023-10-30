using Microsoft.Win32;
using PizzariaDoZe.Dominio.ModuloEndereco;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using PizzariaDoZe.Infra.Orm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.ModuloEndereco {
    public class RepositorioEnderecoOrm: RepositorioBaseORM<Endereco>, IRepositorioEndereco {

 
            public RepositorioEnderecoOrm(PizzariaDoZeDbContext dbContext) : base(dbContext) {
            }

            //public void Inserir(Ingrediente ingrediente) {
            //    throw new NotImplementedException();
            //}

            public Endereco SelecionarPorCep(string cep) {

                return registros.FirstOrDefault(x => x.Cep == cep);
            }

        public Endereco SelecionarPorNome(string nome) {
            throw new NotImplementedException();
        }
    }
}
