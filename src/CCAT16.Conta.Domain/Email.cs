using System;

namespace CCAT16.Conta.Domain
{
    public class Email
    {
        public string Endereco { get; private set; }

        public Email(string email)
        {
            // TODO: criar validação de e-mail
            Endereco = email;
        }

    }
}
