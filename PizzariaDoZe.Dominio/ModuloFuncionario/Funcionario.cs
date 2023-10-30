using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloCliente;
using PizzariaDoZe.Dominio.ModuloEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloFuncionario {
    public class Funcionario: EntidadeBase<Funcionario> {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string Matricula { get; set; }

        public GrupoFuncionarioEnum GrupoFuncionario { get; set; }

        public string NumeroDaCasa { get; set; }

        public string Complemento { get; set; }

        public Endereco Endereco { get; set; }


        public override void Atualizar(Funcionario registro) {

            Nome = registro.Nome;
            Email = registro.Email;
            Telefone = registro.Telefone;
            Cpf = registro.Cpf;
            Complemento = registro.Complemento;
            Endereco = registro.Endereco;
            Senha = registro.Senha;
            Matricula = registro.Matricula;
            GrupoFuncionario = registro.GrupoFuncionario;

        }
        public Funcionario() { }

        public Funcionario(string Nome) {
            this.Nome = Nome;
        }
        public Funcionario(string nome, string email, string telefone, string cpf, string complemento, Endereco endereco) : this(nome) {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            Complemento = complemento;
            Endereco = endereco;


        }
        public Funcionario(Guid id, string nome, string email, string telefone, string cpf, string complemento, Endereco endereco) : this(nome) {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Cpf = cpf;
            Complemento = complemento;
            Endereco = endereco;

        }

        public override string? ToString() {
            return Nome;
        }
    }
}

