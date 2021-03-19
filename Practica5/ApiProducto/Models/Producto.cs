using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiProducto.Models
{
    public enum Celulares
    {
        Apple,
        Samsung,
        Xiaomi,
        Huawei,
        Sony,

    }
    public class Producto
    {
        [Key]
        [Required]
        public int Codigo_de_Producto { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 1, ErrorMessage = ("Ingrese codigo entre 1 a 200 caracteres"))]
        public string Descripción { get; set; }
        public string Foto { get; set; }
        public Celulares Categoría { get; set; }
        public double Precio { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}")]
        public DateTime Fecha_de_creación_del_producto { get; set; }


    }
}