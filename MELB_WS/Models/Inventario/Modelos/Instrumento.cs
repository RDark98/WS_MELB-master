using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MELB_WS.Models.Inventario
{
    public class Instrumento
    {
        public int ID_Instrumento { get; set; }
        public string Nombre { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public Byte[] Imagen { get; set;}
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public String Estado { get; set; }

    }
}