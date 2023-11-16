using PizzariaDoZe.Dominio.Compartilhado;

namespace PizzariaDoZe.Dominio.ModuloBebida {
    public class Bebida : EntidadeBase<Bebida> {

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public TipoBebidaEnum Tipo { get; set; }
        public TamanhoBebidaEnum Tamanho { get; set; }



        public Bebida() { }

        public Bebida(string nome, decimal valor, TipoBebidaEnum tipo, TamanhoBebidaEnum tamanho) {
            Nome = nome;
            Valor = valor;
            Tipo = tipo;
            Tamanho = tamanho;
        }

        public override void Atualizar(Bebida registro) {
            Nome = registro.Nome;
            Valor = registro.Valor;
            Tipo = registro.Tipo;
            Tamanho = registro.Tamanho;
        }

        public override string? ToString() {
            return Nome +" "+ Tamanho;
        }
    }
}
