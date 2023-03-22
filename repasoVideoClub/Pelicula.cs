using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace repasoVideoClub
{
    internal class Pelicula
    {
        private int nroCopia;
        private string titulo;
        private string sinopsis;
        private string genero;
        private string paisOrigen;
        private List<Trailer> trailers;

        public Pelicula(int nroCopia, string titulo, string sinopsis, string genero, string paisOrigen)
        {
            this.nroCopia = nroCopia;
            this.titulo = titulo;
            this.sinopsis = sinopsis;
            this.genero = genero;
            this.paisOrigen = paisOrigen;
            this.trailers = new List<Trailer>();
        }

        public void AgregarTrailer(string url, int duracion)
        {
            Trailer triler1 = new Trailer(url, duracion);
            trailers.Add(triler1);
        }

        public int GetNroCopia() => this.nroCopia;
        public string GetTitulo() => this.titulo;
        public string GetSinopsis() => this.sinopsis;
        public string GetGenero() => this.genero;
        public string GetPaisOrigen() => this.paisOrigen;
        public List<Trailer> Trailers => this.trailers;

        public void SetNroCopia(int nroCopia) => this.nroCopia = nroCopia;
        public void SetTitulo(string titulo) => this.titulo = titulo;
        public void SetSinopsis(string sinopsis) => this.sinopsis = sinopsis;
        public void Setgenero(string genero) => this.genero = genero;
        public void SetPaisOrigen(string paisOrigen) => this.paisOrigen = paisOrigen;
        public void SetTrailers(List<Trailer> trailers) => this.trailers = trailers;

        //punto V)
        public int TotalDuracion()
        {
            int total = 0;
            foreach (Trailer item in this.trailers)
            {
                total = total + item.GetDuracionSeg();
            }
            return total;
        }
    }
}
