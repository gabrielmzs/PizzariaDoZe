using FluentResults;
using PizzariaDoZe.Dominio.ModuloBebida;
using Serilog;

namespace PizzariaDoZe.Aplicacao.ModuloBebida {
    public class ServicoBebida {

        private IRepositorioBebida repositorioBebida;
        private IValidadorBebida validadorBebida;

        public ServicoBebida(IRepositorioBebida repositorioBebida, IValidadorBebida validadorBebida) {

            this.repositorioBebida = repositorioBebida;
            this.validadorBebida = validadorBebida;

        }

        public Result Inserir(Bebida bebida) {
            Log.Debug("Tentando inserir Bebida...{@d}", bebida);

            List<string> erros = ValidarBebida(bebida);

            if (erros.Count() > 0)
                
                return Result.Fail(erros); //cenário 2

            try {
                repositorioBebida.Inserir(bebida);

                Log.Debug("Bebida {BebidaId} inserido com sucesso", bebida.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir Bebida";

                Log.Error(exc, msgErro + "{@d}", bebida);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Bebida bebida) {
            Log.Debug("Tentando editar Bebida...{@d}", bebida);


            List<string> erros = ValidarBebida(bebida);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioBebida.Editar(bebida);

                Log.Debug("Bebida {BebidaId} editado com sucesso", bebida.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //string msgErro;

                //if (ex.Message.Contains("FK_TBAluguel_TBBebida"))
                //    msgErro = "Este bebida está relacionado com um aluguel em aberto e não pode ser editado";
                //else
                //    msgErro = "Falha ao tentar editar Bebida";

                //Log.Error(ex, msgErro + "{@d}", bebida);

                return Result.Fail("Erro");
            }
        }

        public Result Excluir(Bebida bebida) {
            Log.Debug("Tentando excluir Bebida...{@d}", bebida);

            try {
                bool bebidaExiste = repositorioBebida.Existe(bebida);

                if (bebidaExiste == false) {
                    Log.Warning("Bebida {BebidaId} não encontrado para excluir", bebida.Id);

                    return Result.Fail("Bebida não encontrado");
                }

                repositorioBebida.Excluir(bebida);

                Log.Debug("Bebida {BebidaId} excluído com sucesso", bebida.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //List<string> erros = new List<string>();

                //string msgErro;

                //if (ex.message.contains("fk_tbaluguel_tbbebida"))
                //    msgerro = "este bebida está relacionado com um aluguel em aberto e não pode ser excluído";
                //else
                //    msgErro = "Falha ao tentar excluir Bebida";

                //erros.Add(msgErro);

                //Log.Error(ex, msgErro + " {BebidaId}", bebida.Id);

                return Result.Fail("Erro");
            }
        }

        private List<string> ValidarBebida(Bebida bebida) {
            var resultadoValidacao = validadorBebida.Validate(bebida);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (TamanhoJaCadastrado(bebida))
                erros.Add($"Este nome '{bebida.Nome}' já foi cadastrado nesse tamanho.");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool TamanhoJaCadastrado(Bebida bebida) {
            List<Bebida> bebidasCadastradas = repositorioBebida.SelecionarTodos();

                foreach (Bebida b in bebidasCadastradas) {
                    if (b.Nome == bebida.Nome && b.Tamanho == bebida.Tamanho && b.Id != bebida.Id ) {
                        return true; // Já cadastrada
                    }
                }
                return false; // Não cadastrada
            
        }

    }
}

