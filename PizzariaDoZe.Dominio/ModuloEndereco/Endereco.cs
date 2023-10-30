using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloEndereco {
    public class Endereco: EntidadeBase<Endereco> {

        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public Endereco() { }
        public Endereco(string Cep) : this() {
            this.Cep = Cep;
        }
        public Endereco(Guid id, string cep) : this(cep) {
            Id = id;
        }

        public Endereco(Guid id, string cep, string logradouro, string cidade, string bairro, string estado, string pais) : this(cep) {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Pais = pais;
        }

        public Endereco(string cep, string logradouro, string cidade, string bairro, string estado, string pais) : this(cep) {
            Cep = cep;
            Logradouro = logradouro;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Pais = pais;
        }

        public override void Atualizar(Endereco registro) {
            Cep = registro.Cep;
            Logradouro= registro.Logradouro;
            Cidade= registro.Cidade;
            Bairro= registro.Bairro;
            Estado= registro.Estado;
            Pais= registro.Pais;
        }

        public override string? ToString() {
            return Logradouro;
        }
    }
}
