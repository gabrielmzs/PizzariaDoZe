namespace PizzariaDoZe.DAO.ModuloIngrediente {
    public class Ingrediente {

        public int Id { get; set; }
        public string Nome { get; set; }
        public Ingrediente(int id = 0, string nome = "") {
            Id = id;
            Nome = nome;
        }
    }
}
