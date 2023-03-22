using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoVideoClub
{
    internal class Videoclub
    {
        private List<Alquiler> alquileres;
        private List<Pelicula> peliculas;
        private List<Cliente> clientes;

        public Videoclub(List<Alquiler> alquileres, List<Pelicula> peliculas, List<Cliente> clientes)
        {
            this.alquileres = alquileres;
            this.peliculas = peliculas;
            this.clientes = clientes;
        }

        public List<Alquiler> GetAlquileres() => this.alquileres;
        public List<Pelicula> GetPeliculas() => this.peliculas;
        public List<Cliente> GetClientes() => this.clientes;
        public void SetAlquileres(List<Alquiler> alquileres) => this.alquileres = alquileres;
        public void SetPeliculas(List<Pelicula> peliculas) => this.peliculas = peliculas;
        public void SetCliente(List<Cliente> clientes) => this.clientes = clientes;

        // punto i)
        public bool BuscarCliente(string documento)
        {
            foreach (Cliente item in this.clientes)
            {
                if (item.GetDocumento() == documento)
                {
                    return true;
                }
            }
            return false;
        }

        // punto iV)

        public List<Alquiler> DarAlquileresPorDocumento(string documento)
        {
            List<Alquiler> alquileresCliente = new List<Alquiler>();
            foreach (Alquiler item in this.alquileres)
            {
                if(item.GetCliente().GetDocumento() == documento)
                {
                    alquileresCliente.Add(item);
                }
            }
            return alquileresCliente;
        }
    }
}
