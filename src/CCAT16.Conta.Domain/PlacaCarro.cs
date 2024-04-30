using System;

namespace CCAT16.Conta.Dominio
{
    public class PlacaCarro
    {
        public string Numeracao { get; private set; }

        public PlacaCarro(string numeracao)
        {
            // TODO: cria validação da placa
            Numeracao = numeracao;
        }
    }
}
