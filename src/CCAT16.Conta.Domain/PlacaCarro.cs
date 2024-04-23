using System;
using System.Text.RegularExpressions;

namespace CCAT16.Conta.Domain
{
    public class PlacaCarro
    {
        public string Placa { get; private set; }

        public PlacaCarro(string placa)
        {
            // TODO: cria validação da placa
            Placa = placa;
        }
    }
}
