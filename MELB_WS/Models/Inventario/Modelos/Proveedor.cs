using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MELB_WS.Models.Inventario.Modelos
{
    public class Proveedor
    {
        [Required]
        public int ID_Proveedor { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Nombre { get; set; }
        public int Telefono_1 { get; set; }
        public int Telefono_2 { get; set; }
        [StringLength(50, MinimumLength = 1)]
        public string Correo { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Direccion { get; set; }
        public string Imagen { get; set; }
    }
}