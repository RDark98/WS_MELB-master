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
        public string Imagen { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public int ID_Estuche { get; set; }
        public string Nombre_Estuche { get; set; }
        public int ID_Proveedor { get; set; }
        public string Proveedor { get; set; }
        public string Tipo_Ubicacion { get; set; }
        public string Ubicacion { get; set; }
        public object Gaveta { get; set; }
        public object Estante { get; set; }
        public object ID_Aula { get; set; }
        public object Piso { get; set; }
        public object Numero_Aula { get; set; }
    }
    
}