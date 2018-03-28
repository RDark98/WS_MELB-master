using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MELB_WS.Models.Inventario.Modelos
{
    public class Proveedor
    {
        public int ID_Proveedor { get; set; }
        public string Nombre { get; set; }
        public int Telefono_1 { get; set; }
        public int Telefono_2 { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Imagen { get; set; }
    }
}