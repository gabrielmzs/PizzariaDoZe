using PizzariaDoZe.Dominio.Compartilhado;


namespace PizzariaDoZe.Dominio.ModuloSabor {
    public interface IRepositorioSabor: IRepositorio<Sabor> {
        Sabor SelecionarPorNome(string nome);
    }
}


