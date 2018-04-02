using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MELB_WS.Models.Registro_Academico.Modelos
{
    public class Desglose_Remision
    {        
            public int ID_Instrumento { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string Observacion_Inicial { get; set; }
            public string Observacion_Final { get; set; }
        
    }
}