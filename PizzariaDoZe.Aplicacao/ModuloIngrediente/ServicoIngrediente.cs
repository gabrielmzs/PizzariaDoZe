using FluentResults;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Aplicacao.ModuloIngrediente {
    public class ServicoIngrediente {

        private IRepositorioIngrediente repositorioIngrediente;
        private IValidadorIngrediente validadorIngrediente;

        public ServicoIngrediente(IRepositorioIngrediente repositorioIngrediente, IValidadorIngrediente validadorIngrediente) {

            this.repositorioIngrediente = repositorioIngrediente;
            this.validadorIngrediente = validadorIngrediente;

        }

        public Result Inserir(Ingrediente ingrediente) {
            Log.Debug("Tentando inserir ingrediente...{@d}", ingrediente);

            List<string> erros = ValidarIngrediente(ingrediente);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioIngrediente.Inserir(ingrediente);

                Log.Debug("Ingrediente {IngredienteId} inserida com sucesso", ingrediente.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir ingrediente.";

                Log.Error(exc, msgErro + "{@d}", ingrediente);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Ingrediente ingrediente) {
            Log.Debug("Tentando editar ingrediente...{@d}", ingrediente);

            List<string> erros = ValidarIngrediente(ingrediente);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioIngrediente.Editar(ingrediente);

                Log.Debug("Ingrediente {IngredienteId} editada com sucesso", ingrediente.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //string msgErro;

                ////if (ex.Message.Contains("FK_TBCupom_TBIngrediente"))
                ////    msgErro = "Este ingrediente está relacionado com um cupom não pode ser editado";
                //else
                    string msgErro = "Falha ao tentar editar ingrediente";

                Log.Error(ex, msgErro + "{@d}", ingrediente);

                return Result.Fail(msgErro);
            }
        }

        public Result Excluir(Ingrediente ingrediente) {
            Log.Debug("Tentando excluir ingrediente...{@d}", ingrediente);

            try {
                bool ingredienteExiste = repositorioIngrediente.Existe(ingrediente);

                if (ingredienteExiste == false) {
                    Log.Warning("Ingrediente {IngredienteId} não encontrado para excluir", ingrediente.Id);

                    return Result.Fail("Ingrediente não encontrado");
                }

                repositorioIngrediente.Excluir(ingrediente);

                Log.Debug("Ingrediente {IngredienteId} excluído com sucesso", ingrediente.Id);

                return Result.Ok();
            } catch (Exception ex) {
                List<string> erros = new List<string>();

                //string msgErro;

                ////if (ex.Message.Contains("FK_TBCupom_TBIngrediente"))
                ////    msgErro = "Este ingrediente está relacionado com um cupom não pode ser excluído";
                //else
                    string msgErro = "Falha ao tentar excluir ingrediente";

                erros.Add(msgErro);

                Log.Error(ex, msgErro + " {IngredienteId}", ingrediente.Id);

                return Result.Fail(erros);
            }
        }

        private List<string> ValidarIngrediente(Ingrediente ingrediente) {
            var resultadoValidacao = validadorIngrediente.Validate(ingrediente);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(ingrediente))
                erros.Add($"Este nome '{ingrediente.Nome}' já está sendo utilizado");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(Ingrediente ingrediente) {
            Ingrediente ingredienteEncontrado = repositorioIngrediente.SelecionarPorNome(ingrediente.Nome);

            if (ingredienteEncontrado != null &&
                ingredienteEncontrado.Id != ingrediente.Id &&
                ingredienteEncontrado.Nome == ingrediente.Nome) {
                return true;
            }

            return false;
        }
    }
}
