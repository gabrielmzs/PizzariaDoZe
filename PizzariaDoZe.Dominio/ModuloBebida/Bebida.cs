using PizzariaDoZe.Dominio.Compartilhado;

namespace PizzariaDoZe.Dominio.ModuloBebida {
    public class Bebida : EntidadeBase<Bebida> {

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public TipoBebidaEnum Tipo { get; set; }
        public TamanhoBebidaEnum Tamanho { get; set; }

        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }



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

        public string VerificarTamanho() {
            switch (Tamanho) {
                case TamanhoBebidaEnum.ml150:
                    return "150 ml";
                case TamanhoBebidaEnum.ml350:
                    return "350 ml";
                case TamanhoBebidaEnum.ml500:
                    return "500 ml";
                case TamanhoBebidaEnum.ml600:
                    return "600 ml";
                case TamanhoBebidaEnum.litro1:
                    return "1 litro";
                case TamanhoBebidaEnum.litro15:
                    return "1.5 litro";
                case TamanhoBebidaEnum.litro2:
                    return "2 litros";
                default:
                    return "Tamanho não especificado";
            }
        }

        public override string? ToString() {
            string tamanho = VerificarTamanho();
            if(Quantidade == 0 && ValorTotal == 0) return Nome +" - "+ tamanho;
             else return Nome + " - " + tamanho + " - Quantidade: " + Quantidade + " - Valor Total: R$ " + ValorTotal;
        }
    }
}
