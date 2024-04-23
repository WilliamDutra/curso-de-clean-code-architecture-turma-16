using System;

namespace CCAT16.Testes.Dominio
{
    public class ContaTest
    {
        [Fact(DisplayName = "Deve criar uma conta válida")]
        public void Deve_criar_uma_conta_valida()
        {
            var novaConta = Conta.Domain.Conta.Criar("Jonh Doe", "jonhdoe@gmail.com", "12345678910", false, true, "AAABC1234");
            Assert.NotEqual(null, novaConta);
        }

        [Fact(DisplayName = "Deve criar uma conta inválida")]
        public void Deve_criar_uma_conta_invalida()
        {
            Assert.Fail("");
        }
    }
}
