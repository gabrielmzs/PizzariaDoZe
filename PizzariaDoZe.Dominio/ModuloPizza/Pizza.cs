using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloSabor;
using PizzariaDoZe.Dominio.ModuloValor;

namespace PizzariaDoZe.Dominio.ModuloPizza {
    public class Pizza : EntidadeBase<Pizza> {

        public TamanhoPizzaEnum Tamanho {  get; set; }
        public TipoBordaEnum Borda {  get; set; }
        public decimal Valor { get; set; }
        public List<Sabor> Sabores {  get; set; }
        public override void Atualizar(Pizza registro) {
            throw new NotImplementedException();
        }

        public override string ToString() {

            if (Sabores[2] != null) {

            return $"{Tamanho.ToString()} - Sabor 1: {Sabores[0].Nome}, Sabor 2: {Sabores[1].Nome}, Sabor 3: {Sabores[2].Nome}, Borda: {Borda}";
            }
            else if (Sabores[1] != null) {

                return $"{Tamanho.ToString()} - Sabor 1: {Sabores[0].Nome}, Sabor 2: {Sabores[1].Nome}, Borda: {Borda}";
            }
            else
                return $"{Tamanho.ToString()} - Sabor 1: {Sabores[0].Nome}, Borda: {Borda}";


        }
    }
}
