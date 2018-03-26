using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MELB_WS.Models.BBDD;

namespace MELB_WS.Models.Inventario.Operaciones
{
    /* Descripción : Realiza operaciones de lectura,
                     escritura, modificacion etc.de
                     la seccion de inventario
    */
    public class Operaciones_Inventario
    {
        ConexionBBDD Instancia_BBDD;

        // Obtenemos la referencia de conexion de la BBDD //
        public Operaciones_Inventario()
        {
            Instancia_BBDD = new ConexionBBDD();
            Instancia_BBDD.Abrir_Conexion_BBDD();
        }

        public void Devolver_Lista_Instrumento()
        {

        }

    }
}