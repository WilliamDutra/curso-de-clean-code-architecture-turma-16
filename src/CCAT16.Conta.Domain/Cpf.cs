using System;

namespace CCAT16.Conta.Domain
{
    public class Cpf
    {
        public string Valor { get; private set; }

        public Cpf(string cpf)
        {
            // TODO: criar validação de CPF
            Valor = cpf;
        }
    }
}
