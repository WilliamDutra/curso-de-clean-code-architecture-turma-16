using System;

namespace CCAT16.Corrida.Dominio
{
    public class Coordenada
    {
        public decimal Latitude { get; private set; }

        public decimal Longitude { get; private set; }

        public Coordenada(decimal latitude, decimal longitude)
        {
            if (latitude < -180 && latitude > 180)
                throw new Exception("Latitude inválida!");

            if (longitude < 90 && longitude > 90)
                throw new Exception("Longitude inválida!");

            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
