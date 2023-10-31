using FluentResults;
using PizzariaDoZe.Dominio.ModuloSabor;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Aplicacao.ModuloSabor {
    public class ServicoSabor {

        private IRepositorioSabor repositorioSabor;
        private IValidadorSabor validadorSabor;

        public ServicoSabor(IRepositorioSabor repositorioSabor, IValidadorSabor validadorSabor) {

            this.repositorioSabor = repositorioSabor;
            this.validadorSabor = validadorSabor;

        }

        public Result Inserir(Sabor sabor) {
            Log.Debug("Tentando inserir Sabor...{@d}", sabor);

            List<string> erros = ValidarSabor(sabor);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioSabor.Inserir(sabor);

                Log.Debug("Sabor {SaborId} inserido com sucesso", sabor.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir Sabor";

                Log.Error(exc, msgErro + "{@d}", sabor);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Sabor sabor) {
            Log.Debug("Tentando editar Sabor...{@d}", sabor);

            List<string> erros = ValidarSabor(sabor);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioSabor.Editar(sabor);

                Log.Debug("Sabor {SaborId} editado com sucesso", sabor.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //string msgErro;

                //if (ex.Message.Contains("FK_TBAluguel_TBSabor"))
                //    msgErro = "Este sabor está relacionado com um aluguel em aberto e não pode ser editado";
                //else
                //    msgErro = "Falha ao tentar editar Sabor";

                //Log.Error(ex, msgErro + "{@d}", sabor);

                return Result.Fail("Erro");
            }
        }

        public Result Excluir(Sabor sabor) {
            Log.Debug("Tentando excluir Sabor...{@d}", sabor);

            try {
                bool saborExiste = repositorioSabor.Existe(sabor);

                if (saborExiste == false) {
                    Log.Warning("Sabor {SaborId} não encontrado para excluir", sabor.Id);

                    return Result.Fail("Sabor não encontrado");
                }

                repositorioSabor.Excluir(sabor);

                Log.Debug("Sabor {SaborId} excluído com sucesso", sabor.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //List<string> erros = new List<string>();

                //string msgErro;

                //if (ex.message.contains("fk_tbaluguel_tbsabor"))
                //    msgerro = "este sabor está relacionado com um aluguel em aberto e não pode ser excluído";
                //else
                //    msgErro = "Falha ao tentar excluir Sabor";

                //erros.Add(msgErro);

                //Log.Error(ex, msgErro + " {SaborId}", sabor.Id);

                return Result.Fail("Erro");
            }
        }

        private List<string> ValidarSabor(Sabor sabor) {
            var resultadoValidacao = validadorSabor.Validate(sabor);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(sabor))
                erros.Add($"Este nome '{sabor.Nome}' já está sendo utilizado");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(Sabor sabor) {
            Sabor saborEncontrado = repositorioSabor.SelecionarPorNome(sabor.Nome);

            if (saborEncontrado != null &&
                saborEncontrado.Id != sabor.Id &&
                saborEncontrado.Nome == sabor.Nome) {
                return true;
            }

            return false;
        }

    }
}
