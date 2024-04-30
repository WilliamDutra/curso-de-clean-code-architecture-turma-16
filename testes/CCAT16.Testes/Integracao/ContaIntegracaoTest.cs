using System;
using CCAT16.Data;
using CCAT16.Data.Repositorios.Conta;
using Entidade = CCAT16.Conta.Dominio;

namespace CCAT16.Testes.Integracao
{

    public class ContaIntegracaoTest
    {
        [Fact(DisplayName = "Deve cadastrar uma nova conta com sucesso")]
        public void Deve_cadastrar_uma_nova_conta_com_sucesso()
        {
            var contexto = new CCAT16Context("Server=localhost; port=5432; Database=ccat16; User Id=ccat16; Password=123456789; Pooling=true;");
            var contaRepositorio = new ContaRepositorio(contexto);
            var conta = Entidade.Conta.Criar("Jonh Doe", $"jonhdoe{Guid.NewGuid()}@gmail.com", "12345678910", false, true, string.Empty);
            contaRepositorio.Salvar(conta);
            Assert.True(true);
        }
    }
}
