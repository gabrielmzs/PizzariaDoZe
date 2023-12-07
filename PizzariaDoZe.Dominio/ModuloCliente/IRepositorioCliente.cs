using PizzariaDoZe.Dominio.Compartilhado;

namespace PizzariaDoZe.Dominio.ModuloCliente {
    public interface IRepositorioCliente : IRepositorio<Cliente> {
        Cliente SelecionarPorNome(string nome);
        List<Cliente> SelecionarPorCPF(string cpf);
        List<Cliente> SelecionarListaPorNome(string cpf);
        List<Cliente> SelecionarPorTelefone(string telefone);
    }
}
