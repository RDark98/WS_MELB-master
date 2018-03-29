using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MELB_WS.Models.Inventario.Modelos
{
    public class Estuche
    {
        [Required]
        public int ID_Estuche { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Nombre { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Marca { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Material { get; set; }
        [StringLength(10, MinimumLength = 1)]
        public string Color { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Estado { get; set; }
    }
}