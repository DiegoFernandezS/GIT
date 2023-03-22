using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoVideoClub
{
    internal class Alquiler
    {
        private int nroAlquiler;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private double costoTotal;
        private List<Pelicula> copiasPelicula;
        private Cliente cliente;

        public Alquiler(int nroAlquiler, DateTime fechaInicio, DateTime fechaFin, double costoTotal, List<Pelicula> copiasPelicula, Cliente cliente)
        {
            this.nroAlquiler = nroAlquiler;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.costoTotal = costoTotal;
            this.copiasPelicula = copiasPelicula;
            this.cliente = cliente;
        }

        public int GetNroAlquiler() => this.nroAlquiler;
        public DateTime GetFechaInicio() => this.fechaInicio;
        public DateTime GetFechaFin() => this.fechaFin;
        public double GetCostoTotal() => this.costoTotal;
        public List<Pelicula> GetCopiasPelicula => this.copiasPelicula;
        public Cliente GetCliente() => this.cliente;

        public void SetNroAlquiler(int nroAlquiler) => this.nroAlquiler = nroAlquiler;
        public void SetFechaInicio(DateTime fechaInicio) => this.fechaInicio = fechaInicio;
        public void SetFechaFin(DateTime fechaFin) => this.fechaFin = fechaFin;
        public void SetCostoTotal(double costoTotal) => this.costoTotal = costoTotal;
        public void SetCopiasPelicula(List<Pelicula> copiasPelicula) => this.copiasPelicula = copiasPelicula;
        public void SetCliente(Cliente cliente) => this.cliente = cliente;

        //punto ii)

        public void DatosClienteAlquiler()
        {
            Console.WriteLine("El nombre completo del cliente es: " + cliente.GetNombre() + " " + cliente.GetApellido());
        }

        // punto iii)

        public double CalcularCostoTotal()
        {
            return this.costoTotal = copiasPelicula.Count() * 80;
        }
    }
}
