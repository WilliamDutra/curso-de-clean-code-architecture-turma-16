using System;

namespace CCAT16.Corrida.Domain
{
    public class Corrida
    {
        public int Id { get; private set; }

        public int ContaId { get; private set; }

        public Coordenada Saida { get; private set; }

        public Coordenada Chegada { get; private set; }

        public DateTime Data { get; private set; }

        private Corrida(int id, int contaId, Coordenada saida, Coordenada chegada, DateTime data)
        {
            Id = id;
            ContaId = contaId;
            Saida = saida;
            Chegada = chegada;
            Data = data;
        }

        static Corrida Criar(int contaId, decimal latitudeSaida, decimal longitudeSaida, decimal latitudeChegada, decimal longitudeChegada)
        {
            var data = DateTime.Now;
            return new Corrida(0, contaId, new Coordenada(latitudeSaida, longitudeSaida), new Coordenada(latitudeChegada, longitudeChegada), data);
        }

        static Corrida Restaurar(int id, int contaId, decimal latitudeSaida, decimal longitudeSaida, decimal latitudeChegada, decimal longitudeChegada, DateTime data)
        {
            return new Corrida(id, contaId, new Coordenada(latitudeSaida, longitudeSaida), new Coordenada(latitudeChegada, longitudeChegada), data);
        }

    }
}
