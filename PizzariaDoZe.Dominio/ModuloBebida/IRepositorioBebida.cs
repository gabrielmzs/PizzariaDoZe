using PizzariaDoZe.Dominio.Compartilhado;

namespace PizzariaDoZe.Dominio.ModuloBebida {
    public interface IRepositorioBebida: IRepositorio<Bebida> {

        Bebida SelecionarPorNome(string nome);
    }
}
