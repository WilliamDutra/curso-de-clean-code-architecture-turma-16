using System;

namespace CCAT16.Conta.Dominio
{
    public class Conta
    {
        public int Id { get; private set; }

        public string Nome { get; private set; }

        public Email Email { get; private set; }

        public string Cpf { get; private set; }

        public bool EhMotorista { get; private set; }

        public bool EhPassageiro { get; private set; }

        public PlacaCarro? PlacaDoCarro { get; private set; }

        private Conta(int id, string nome, string email, string cpf, bool ehMortorista, bool ehPassageiro, PlacaCarro? placaDoCarro)
        {
            Id = id;
            Nome = nome;
            Email = new Email(email);
            Cpf = cpf;
            EhMotorista = ehMortorista;
            EhPassageiro = ehPassageiro;
            PlacaDoCarro = placaDoCarro;
        }

        public static Conta Criar(string nome, string email, string cpf, bool ehMotorista, bool ehPassageiro, string? placaDoCarro)
        {
            return new Conta(0, nome, email, cpf, ehMotorista, ehPassageiro, new PlacaCarro(placaDoCarro));
        }

        public static Conta Restaurar(int id, string nome, string email, string cpf, bool ehMotorista, bool ehPassageiro, string? placaDoCarro)
        {
            return new Conta(id, nome, email, cpf, ehMotorista, ehPassageiro, new PlacaCarro(placaDoCarro));
        }

    }
}
