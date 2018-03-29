using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MELB_WS.Models.Inventario
{

    public class Instrumento
    {
        [Required] 
        public int ID_Instrumento { get; set; }
        [StringLength(15,MinimumLength = 1)]
        public string Nombre { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Material { get; set; }
        [StringLength(10, MinimumLength = 1)]
        public string Color { get; set; }
        public string Imagen { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Marca { get; set; }
        [StringLength(50, MinimumLength = 1)]
        public string Descripcion { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Estado { get; set; }
        [Required]
        public int ID_Estuche { get; set; }
        public string Nombre_Estuche { get; set; }
        [Required]
        public int ID_Proveedor { get; set; }
        public string Proveedor { get; set; }
        [Required]
        public string Tipo_Ubicacion { get; set; }
        public string Ubicacion { get; set; }
        
        public object Gaveta { get; set; }
        
        public object Estante { get; set; }
        
        public object ID_Aula { get; set; }
        
        public object Piso { get; set; }
        
        public object Numero_Aula { get; set; }
    }
    
}