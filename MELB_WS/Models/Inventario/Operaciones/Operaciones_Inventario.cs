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
        private JavaScriptSerializer JSON = new JavaScriptSerializer();
        private SqlDataReader SqlReader;
        private SqlCommand CMD;

        // Inicializa la conexión hacia la BBDD //
        public Operaciones_Inventario()
        {
            Instancia_BBDD = new ConexionBBDD();
        }

        // Devuelve la lista total de todos los instrumentos //
        public dynamic Devolver_Lista_Todos_Instrumentos(int Bandera = 1 , int ID_Instrumento = 0)
        {
            if (Instancia_BBDD.Abrir_Conexion_BBDD() == true)
            {                
                CMD = new SqlCommand("I_Listado_Instrumentos", Instancia_BBDD.Conexion);
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.Add("@ID_Instrumento", SqlDbType.Int).Value = ID_Instrumento;
                CMD.Parameters.Add("@Bandera", SqlDbType.Bit).Value = Bandera;
                SqlReader = CMD.ExecuteReader();
                List<Instrumento> Lista_Instrumento = new List<Instrumento>();
                while (SqlReader.Read())
                {
                    Instrumento Nuevo_Instrumento = new Instrumento();
                    Nuevo_Instrumento.ID_Instrumento = SqlReader.GetInt32(0);
                    Nuevo_Instrumento.Nombre = SqlReader.GetString(1);
                    Nuevo_Instrumento.Material = SqlReader.GetString(2);
                    Nuevo_Instrumento.Color = SqlReader.GetString(3);
                    Nuevo_Instrumento.Imagen = SqlReader.GetString(4);
                    Nuevo_Instrumento.Marca = SqlReader.GetString(5);
                    Nuevo_Instrumento.Descripcion = SqlReader.GetString(6);
                    Nuevo_Instrumento.Estado = SqlReader.GetString(7);
                    Nuevo_Instrumento.Nombre_Estuche = SqlReader.GetString(8);
                    Nuevo_Instrumento.Proveedor = SqlReader.GetString(9);
                    Nuevo_Instrumento.Ubicacion = SqlReader.GetString(10);
                    Lista_Instrumento.Add(Nuevo_Instrumento);
                }
                CMD.Dispose();
                Instancia_BBDD.Cerrar_Conexion();
                return JSON.Serialize(Lista_Instrumento);
            }
            else
            {
                return "{ \"Error\": { \"Mensaje_Error\": \"Error de conexión con la base de datos\"}";
            }
        }

        public void Insertar_Instrumento()
        {

        }
    }
}