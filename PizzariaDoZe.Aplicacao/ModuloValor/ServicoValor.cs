using FluentResults;
using PizzariaDoZe.Dominio.ModuloValor;
using Serilog;

namespace PizzariaDoZe.Aplicacao.ModuloValor {

    public class ServicoValor {
        private IRepositorioValor repositorioValor;
        private IValidadorValor validadorValor;

        public ServicoValor(IRepositorioValor repositorioValor, IValidadorValor validadorValor) {

            this.repositorioValor = repositorioValor;
            this.validadorValor = validadorValor;

        }

        public Result Inserir(Valor valor) {
            Log.Debug("Tentando inserir Valor...{@d}", valor);

            List<string> erros = ValidarValor(valor);

            if (erros.Count() > 0)

                return Result.Fail(erros); //cenário 2

            try {
                repositorioValor.Inserir(valor);

                Log.Debug("Valor {ValorId} inserido com sucesso", valor.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir Valor";

                Log.Error(exc, msgErro + "{@d}", valor);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Valor valor) {
            Log.Debug("Tentando editar Valor...{@d}", valor);

            List<string> erros = ValidarValor(valor);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioValor.Editar(valor);

                Log.Debug("Valor {ValorId} editado com sucesso", valor.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //string msgErro;

                //if (ex.Message.Contains("FK_TBAluguel_TBValor"))
                //    msgErro = "Este valor está relacionado com um aluguel em aberto e não pode ser editado";
                //else
                //    msgErro = "Falha ao tentar editar Valor";

                //Log.Error(ex, msgErro + "{@d}", valor);

                return Result.Fail("Erro");
            }
        }

        public Result Excluir(Valor valor) {
            Log.Debug("Tentando excluir Valor...{@d}", valor);

            try {
                bool valorExiste = repositorioValor.Existe(valor);

                if (valorExiste == false) {
                    Log.Warning("Valor {ValorId} não encontrado para excluir", valor.Id);

                    return Result.Fail("Valor não encontrado");
                }

                repositorioValor.Excluir(valor);

                Log.Debug("Valor {ValorId} excluído com sucesso", valor.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //List<string> erros = new List<string>();

                //string msgErro;

                //if (ex.message.contains("fk_tbaluguel_tbvalor"))
                //    msgerro = "este valor está relacionado com um aluguel em aberto e não pode ser excluído";
                //else
                //    msgErro = "Falha ao tentar excluir Valor";

                //erros.Add(msgErro);

                //Log.Error(ex, msgErro + " {ValorId}", valor.Id);

                return Result.Fail("Erro");
            }
        }

        private List<string> ValidarValor(Valor valor) {
            var resultadoValidacao = validadorValor.Validate(valor);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (ValorJaCadastrado(valor))
                erros.Add($"A pizza '{valor.Tamanho}'-'{valor.Categoria}' já foi cadastrada no sistema.");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool ValorJaCadastrado(Valor valor) {
            List<Valor> valoresCadastradas = repositorioValor.SelecionarTodos();

            foreach (Valor v in valoresCadastradas) {
                if (v.Categoria == valor.Categoria && v.Tamanho == valor.Tamanho && v.Id != valor.Id) {
                    return true; // Já cadastrada
                }
            }
            return false; // Não cadastrada

        }
    }
}

