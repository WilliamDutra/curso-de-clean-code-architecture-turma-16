using System;

namespace CCAT16.Conta.Dominio
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
