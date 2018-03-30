using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MELB_WS.Models.Inventario.Modelos
{
    public class Estudiante
    {
        [Required]
        public int ID_Estudiante { get; set; }
        [StringLength(20, MinimumLength = 1)]
        public string Nombre { get; set; }
        [StringLength(20, MinimumLength = 1)]
        public string Apellido { get; set; }
        [StringLength(25, MinimumLength = 1)]
        public string Correo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        [StringLength(20, MinimumLength = 1)]
        public string Tutor_Nombre { get; set; }
        [StringLength(25, MinimumLength = 1)]
        public string Tutor_Apellido { get; set; }
        [StringLength(14, MinimumLength = 1)]
        public string Cedula { get; set; }
        public Decimal Telefono_1 { get; set; }
        public Decimal Telefono_2 { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string Direccion { get; set; }
        [StringLength(1, MinimumLength = 1)]
        public string Sexo { get; set; }
        public string Foto { get; set; }
        [StringLength(15, MinimumLength = 1)]
        public string Rol { get; set; }
        public DateTime Ano_Ingreso { get; set; }
        public int ID_Beca { get; set; }

    }
}