using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MELB_WS.Models.BBDD;
using System.Data;

namespace MELB_WS.Models.Inventario.Operaciones
{

    public class Operaciones_Inventario
    {
        private ConexionBBDD Instancia_BBDD;

        // Inicializa la conexión hacia la BBDD //
        public Operaciones_Inventario()
        {
            Instancia_BBDD = new ConexionBBDD();
            Instancia_BBDD.Abrir_Conexion_BBDD();
        }

        // Devuelve la lista total de todos los instrumentos //
        public void Devolver_Lista_Todos_Instrumentos()
        {
            SqlCommand Comando = new SqlCommand("I_Listado_Instrumentos", Instancia_BBDD.Conexion);
            Comando.CommandType = CommandType.StoredProcedure;

         
            Comando.Parameters.AddWithValue("Intevalo_Menor", 1);
            Comando.Parameters.AddWithValue("Intervalo_Mayor", 30);
            Comando.Parameters.AddWithValue("Bandera", 0);

            Comando.ExecuteNonQuery();

        }

    }
}