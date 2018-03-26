using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MELB_WS.Models.BBDD
{ 

    /*
        Descripción : Contiene la conexión a la base de datos
                      mediante la cual vamos a hacer las oper
                      aciones con los prodecimientos almacena
                      dos.
    */

    public class ConexionBBDD
    {
        private string Cadena_Conexion = "Server=tcp:melb.database.windows.net,1433;Initial Catalog=MeLB;Persist Security Info=False;User ID=MeLbAdmin;Password=eXOsSMjv9;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection Conexion = null;

        public Boolean Abrir_Conexion_BBDD()
        {
            Conexion = new SqlConnection(Cadena_Conexion);
            try
            {
                Conexion.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Boolean Cerrar_Conexion()
        {
            Conexion.Dispose();
            return true;
        }

    }
}