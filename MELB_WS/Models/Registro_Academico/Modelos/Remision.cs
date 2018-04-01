using MELB_WS.Models.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MELB_WS.Models.Registro_Academico.Modelos
{
    public class Remision
    {
        public int  ID_Remision { get; set; }
        public string Nombre_Estudiante { get; set; }
        public DateTime Fecha_Prestamo { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public string Estado_Remision { get; set; }
        public object  ID_Estado_Remision { get; set; }
        public object ID_Estudiante { get; set; }
        public string Empleado_Nombre { get; set; }
        public object Empleado_ID { get; set; }
        public string ID_Instrumentos { get; set; }
        public string Observaciones_Iniciales { get; set; }
        public string Observaciones_Finales { get; set; }
 
        public List<Desglose_Remision> Lista_Desglose { get; set; }
       
    }
}