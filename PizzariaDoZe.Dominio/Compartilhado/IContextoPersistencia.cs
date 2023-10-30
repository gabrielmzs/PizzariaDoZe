

namespace PizzariaDoZe.Dominio.Compartilhado {
    public interface IContextoPersistencia {

        public void DesfazerAlteracoes();

        public void GravarDados();
    }
}
