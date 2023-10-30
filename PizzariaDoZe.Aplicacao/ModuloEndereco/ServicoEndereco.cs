using FluentResults;
using PizzariaDoZe.Dominio.ModuloEndereco;
using PizzariaDoZe.Dominio.ModuloEndereco;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Aplicacao.ModuloEndereco {
    public class ServicoEndereco {
        private IRepositorioEndereco repositorioEndereco;
        private IValidadorEndereco validadorEndereco;

        public ServicoEndereco(IRepositorioEndereco repositorioEndereco, IValidadorEndereco validadorEndereco) {

            this.repositorioEndereco = repositorioEndereco;
            this.validadorEndereco = validadorEndereco;

        }

        public Result Inserir(Endereco endereco) {
            Log.Debug("Tentando inserir Endereco...{@d}", endereco);

            List<string> erros = ValidarEndereco(endereco);

            if (erros.Count() > 0)
                return Result.Fail(erros); //cenário 2

            try {
                repositorioEndereco.Inserir(endereco);

                Log.Debug("Endereco {EnderecoId} inserido com sucesso", endereco.Id);

                return Result.Ok(); //cenário 1
            } catch (Exception exc) {
                string msgErro = "Falha ao tentar inserir Endereco";

                Log.Error(exc, msgErro + "{@d}", endereco);

                return Result.Fail(msgErro); //cenário 3
            }
        }

        public Result Editar(Endereco endereco) {
            Log.Debug("Tentando editar Endereco...{@d}", endereco);

            List<string> erros = ValidarEndereco(endereco);

            if (erros.Count() > 0)
                return Result.Fail(erros);

            try {
                repositorioEndereco.Editar(endereco);

                Log.Debug("Endereco {EnderecoId} editado com sucesso", endereco.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //string msgErro;

                //if (ex.Message.Contains("FK_TBAluguel_TBEndereco"))
                //    msgErro = "Este endereco está relacionado com um aluguel em aberto e não pode ser editado";
                //else
                //    msgErro = "Falha ao tentar editar Endereco";

                //Log.Error(ex, msgErro + "{@d}", endereco);

                return Result.Fail("Erro");
            }
        }

        public Result Excluir(Endereco endereco) {
            Log.Debug("Tentando excluir Endereco...{@d}", endereco);

            try {
                bool enderecoExiste = repositorioEndereco.Existe(endereco);

                if (enderecoExiste == false) {
                    Log.Warning("Endereco {EnderecoId} não encontrado para excluir", endereco.Id);

                    return Result.Fail("Endereco não encontrado");
                }

                repositorioEndereco.Excluir(endereco);

                Log.Debug("Endereco {EnderecoId} excluído com sucesso", endereco.Id);

                return Result.Ok();
            } catch (Exception ex) {
                //List<string> erros = new List<string>();

                //string msgErro;

                //if (ex.message.contains("fk_tbaluguel_tbendereco"))
                //    msgerro = "este endereco está relacionado com um aluguel em aberto e não pode ser excluído";
                //else
                //    msgErro = "Falha ao tentar excluir Endereco";

                //erros.Add(msgErro);

                //Log.Error(ex, msgErro + " {EnderecoId}", endereco.Id);

                return Result.Fail("Erro");
            }
        }

        private List<string> ValidarEndereco(Endereco endereco) {
            var resultadoValidacao = validadorEndereco.Validate(endereco);

            List<string> erros = new List<string>();

            if (resultadoValidacao != null)
                erros.AddRange(resultadoValidacao.Errors.Select(x => x.ErrorMessage));

            if (NomeDuplicado(endereco))
                erros.Add($"Este Cep '{endereco.Cep}' já está sendo utilizado");

            foreach (string erro in erros) {
                Log.Warning(erro);
            }

            return erros;
        }

        private bool NomeDuplicado(Endereco endereco) {
            Endereco enderecoEncontrado = repositorioEndereco.SelecionarPorNome(endereco.Cep);

            if (enderecoEncontrado != null &&
                enderecoEncontrado.Id != endereco.Id &&
                enderecoEncontrado.Cep == endereco.Cep) {
                return true;
            }

            return false;
        }
    }
}
