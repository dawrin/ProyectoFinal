using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class OrdenesModel
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; }
        public string NombreOrden { get; set; }
        public int Cantidad { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }


    }
}
