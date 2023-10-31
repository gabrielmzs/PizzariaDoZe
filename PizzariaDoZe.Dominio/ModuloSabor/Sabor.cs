using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Dominio.ModuloSabor {
    public class Sabor : EntidadeBase<Sabor> {

        public string Nome { get; set; }
        public TipoSaborEnum Tipo { get; set; }
        public CategoriaSaborEnum Categoria { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public byte[] Foto { get; set; }

        public Sabor() { }

        public Sabor(string nome, TipoSaborEnum tipo, CategoriaSaborEnum categoria, List<Ingrediente> ingredientes, byte[] foto) {
            Nome = nome;
            Tipo = tipo;
            Categoria = categoria;
            Ingredientes = ingredientes;
            Foto = foto;
        }

        public Sabor(string nome, TipoSaborEnum tipo, CategoriaSaborEnum categoria, List<Ingrediente> ingredientes) {
            Nome = nome;
            Tipo = tipo;
            Categoria = categoria;
            Ingredientes = ingredientes;
           
        }



        public override void Atualizar(Sabor registro) {
            Nome = registro.Nome;
            Tipo = registro.Tipo;
            Categoria = registro.Categoria;
            Ingredientes = registro.Ingredientes;
            Foto = registro.Foto;
        }
    }
}
