using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoVideoClub
{
    internal class Cliente
    {
        private string documento;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;

        public Cliente(string documento, string nombre, string apellido, string direccion, string telefono)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public string GetDocumento() => this.documento;
        public string GetNombre() => this.nombre;
        public string GetApellido() => this.apellido;
        public string GetDireccion() => this.direccion;
        public string GetTelefono() => this.telefono;
        public void SetDocumento(string documento) => this.documento = documento;
        public void SetNombre(string nombre) => this.nombre = nombre;
        public void SetApellido(string apellido) => this.apellido = apellido;
        public void SetDireccion(string direccion) => this.direccion = direccion;
        public void SetTelefono(string telefono) => this.telefono = telefono;
    }
}
