using PizzariaDoZe.Dominio.Compartilhado;

namespace PizzariaDoZe.Dominio.ModuloValor {
    public class Valor : EntidadeBase<Valor> {

        public decimal ValorPizza { get; set; }
        public decimal ValorBorda { get; set; }
        public TamanhoPizzaEnum Tamanho { get; set; }
        public CategoriaPizzaEnum Categoria { get; set; }

        public Valor() { }

        public Valor(decimal valorPizza, decimal valorBorda, TamanhoPizzaEnum tamanho, CategoriaPizzaEnum categoria) {
            ValorPizza = valorPizza;
            ValorBorda = valorBorda;
            Tamanho = tamanho;
            Categoria = categoria;
        }

        public override void Atualizar(Valor registro) {
            ValorPizza = registro.ValorPizza;
            ValorBorda = registro.ValorBorda;
            Tamanho = registro.Tamanho;
            Categoria = registro.Categoria;
        }
    }
}
