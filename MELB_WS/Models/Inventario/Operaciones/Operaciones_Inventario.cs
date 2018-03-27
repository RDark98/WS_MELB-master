using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MELB_WS.Models.BBDD;
using System.Data;
using System.Web.Script.Serialization;

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
        public dynamic Devolver_Lista_Todos_Instrumentos()
        {
            SqlCommand CMD = new SqlCommand("I_Listado_Instrumentos", Instancia_BBDD.Conexion);
            SqlDataReader SqlReader;
            CMD.CommandType = CommandType.StoredProcedure;

            /*
            CMD.Parameters.AddWithValue("Intevalo_Menor", 1);
            CMD.Parameters.AddWithValue("Intervalo_Mayor", 30);
            CMD.Parameters.AddWithValue("Bandera", 0);*/

            SqlReader = CMD.ExecuteReader();

            List<Instrumento> Lista_Instrumento= new List<Instrumento>();

            while (SqlReader.Read())
            {
                Instrumento Nuevo_Instrumento = new Instrumento();
                Nuevo_Instrumento.ID_Instrumento = SqlReader.GetInt32(0);
                Nuevo_Instrumento.Nombre = SqlReader.GetString(1);
                Nuevo_Instrumento.Material= SqlReader.GetString(2);
                Nuevo_Instrumento.Color = SqlReader.GetString(3);
                Nuevo_Instrumento.Imagen = SqlReader.GetString(4);
                Nuevo_Instrumento.Marca = SqlReader.GetString(5);
                Nuevo_Instrumento.Descripcion = SqlReader.GetString(6);
                Nuevo_Instrumento.Estado = SqlReader.GetString(7);
                Nuevo_Instrumento.Nombre_Estuche = SqlReader.GetString(8);
                Nuevo_Instrumento.Proveedor = SqlReader.GetString(9);
                Lista_Instrumento.Add(Nuevo_Instrumento);
            }

            var JSON= new JavaScriptSerializer();
            return  JSON.Serialize(Lista_Instrumento);            
        }

    }
}