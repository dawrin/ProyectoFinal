using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class DataProductos
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }     
        public string Estado { get; set; }
        public string Categoria { get; set; }
    }

    public enum _categoria
    {
        Telefonos,
        Tablets,
        Computadoras

    }
}
