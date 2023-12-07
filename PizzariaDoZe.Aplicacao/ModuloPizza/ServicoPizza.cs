using FluentResults;
using PizzariaDoZe.Dominio.ModuloPizza;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Aplicacao.ModuloPizza {
    public class ServicoPizza {

        private IRepositorioPizza repositorioPizza;
        private IValidadorPizza validadorPizza;

        public ServicoPizza(IRepositorioPizza repositorioPizza, IValidadorPizza validadorPizza) {

            this.repositorioPizza = repositorioPizza;
            this.validadorPizza = validadorPizza;

        }

        public Result Inserir(Pizza pizza) {
            Log.Debug("Tentando inserir Pizza...{@d}", pizza);

            List<string> erros = ValidarPizza(pizza);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioPizza.Inserir(pizza);

                Log.Debug("Pizza {PizzaId} inserido com sucesso", pizza.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir Pizza";

                Log.Error(exc, msgErro + "{@d}", pizza);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Pizza pizza) {
            Log.Debug("Tentando editar Pizza...{@d}", pizza);

            List<string> erros = ValidarPizza(pizza);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioPizza.Editar(pizza);

                Log.Debug("Pizza {PizzaId} editado com sucesso", pizza.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //string msgErro;

                //if (ex.Message.Contains("FK_TBAluguel_TBPizza"))
                //    msgErro = "Este pizza está relacionado com um aluguel em aberto e não pode ser editado";
                //else
                //    msgErro = "Falha ao tentar editar Pizza";

                //Log.Error(ex, msgErro + "{@d}", pizza);

                return Result.Fail("Erro");
            }
        }

        public Result Excluir(Pizza pizza) {
            Log.Debug("Tentando excluir Pizza...{@d}", pizza);

            try {
                bool pizzaExiste = repositorioPizza.Existe(pizza);

                if (pizzaExiste == false) {
                    Log.Warning("Pizza {PizzaId} não encontrado para excluir", pizza.Id);

                    return Result.Fail("Pizza não encontrado");
                }

                repositorioPizza.Excluir(pizza);

                Log.Debug("Pizza {PizzaId} excluído com sucesso", pizza.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //List<string> erros = new List<string>();

                //string msgErro;

                //if (ex.message.contains("fk_tbaluguel_tbpizza"))
                //    msgerro = "este pizza está relacionado com um aluguel em aberto e não pode ser excluído";
                //else
                //    msgErro = "Falha ao tentar excluir Pizza";

                //erros.Add(msgErro);

                //Log.Error(ex, msgErro + " {PizzaId}", pizza.Id);

                return Result.Fail("Erro");
            }
        }

        private List<string> ValidarPizza(Pizza pizza) {
            var resultadoValidacao = validadorPizza.Validate(pizza);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));



            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }

        

    }
}
