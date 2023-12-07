using PizzariaDoZe.Dominio.Compartilhado;
using PizzariaDoZe.Dominio.ModuloCliente;

namespace PizzariaDoZe.Dominio.ModuloValor {
    public interface IRepositorioValor:IRepositorio<Valor> {

        Valor SelecionarValorEspecifico(TamanhoPizzaEnum tamanho, CategoriaPizzaEnum categoria);
    }
}
