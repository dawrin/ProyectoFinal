using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class DataProductos
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; }
        public byte[] FotoSlider { get; set; }
        [Display(Name = "Articulo")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }     
        public string Estado { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }

        
        public string NombreOrden { get; set; }
        [Display(Name = "Cliente")]
        public string NombreCliente { get; set; }
        [Display(Name = "Apellidos")]
        public string ApellidoCliente { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public string FechaCliente { get; set; }
        public string Telefono { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }

    }

    public enum _categoria
    {
        Telefonos,
        Tablets,
        Computadoras
    }
    public enum _estado
    {
        procesando,
        Enviado,
        Completado
    }
}
