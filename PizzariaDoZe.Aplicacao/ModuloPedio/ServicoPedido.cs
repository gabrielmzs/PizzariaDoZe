using FluentResults;
using PedidoriaDoZe.Dominio.ModuloPedido;
using PizzariaDoZe.Dominio.ModuloPedido;
using Serilog;

namespace PedidoriaDoZe.Aplicacao.ModuloPedio {
    public class ServicoPedido {

        private IRepositorioPedido repositorioPedido;
        private IValidadorPedido validadorPedido;

        public ServicoPedido(IRepositorioPedido repositorioPedido, IValidadorPedido validadorPedido) {

            this.repositorioPedido = repositorioPedido;
            this.validadorPedido = validadorPedido;

        }

        public Result Inserir(Pedido pedido) {
            Log.Debug("Tentando inserir Pedido...{@d}", pedido);

            List<string> erros = ValidarPedido(pedido);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioPedido.Inserir(pedido);

                Log.Debug("Pedido {PedidoId} inserido com sucesso", pedido.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir Pedido";

                Log.Error(exc, msgErro + "{@d}", pedido);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Pedido pedido) {
            Log.Debug("Tentando editar Pedido...{@d}", pedido);

            List<string> erros = ValidarPedido(pedido);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioPedido.Editar(pedido);

                Log.Debug("Pedido {PedidoId} editado com sucesso", pedido.Id);

                return Result.Ok();
            } catch (Exception ex) {


                return Result.Fail("Erro");
            }
        }

        public Result Excluir(Pedido pedido) {
            Log.Debug("Tentando excluir Pedido...{@d}", pedido);

            try {
                bool pedidoExiste = repositorioPedido.Existe(pedido);

                if (pedidoExiste == false) {
                    Log.Warning("Pedido {PedidoId} não encontrado para excluir", pedido.Id);

                    return Result.Fail("Pedido não encontrado");
                }

                repositorioPedido.Excluir(pedido);

                Log.Debug("Pedido {PedidoId} excluído com sucesso", pedido.Id);

                return Result.Ok();
            } catch (Exception ex) {
            

                return Result.Fail("Erro");
            }
        }

        private List<string> ValidarPedido(Pedido pedido) {
            var resultadoValidacao = validadorPedido.Validate(pedido);

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
