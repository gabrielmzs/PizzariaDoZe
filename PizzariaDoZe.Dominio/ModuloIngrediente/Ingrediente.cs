using PizzariaDoZe.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloIngrediente {
    public class Ingrediente : EntidadeBase<Ingrediente> {
        public string Nome { get; set; }

        public Ingrediente() { }
        public Ingrediente(string Nome) : this() {
            this.Nome = Nome;
        }
        public Ingrediente(Guid id, string nome) : this(nome) {
            Id = id;
        }
        public override void Atualizar(Ingrediente registro) {
            Nome = registro.Nome;
        }

        public override string? ToString() {
            return Nome;
        }
    }
}
