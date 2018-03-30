using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MELB_WS.Models.BBDD;
using System.Data;
using System.Web.Script.Serialization;
using MELB_WS.Models.Inventario.Modelos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MELB_WS.Models.Inventario.Operaciones
{
    /*
     Definicion :  Clase Nueva que contiene las operaciones CRUD
                   de los controladores que participan en
                   los procesos de Registro Académico.
    */

    public class Operaciones_Registro_Academico
    {
        private ConexionBBDD Instancia_BBDD;
        private SqlDataReader SqlReader;
        private SqlCommand CMD;

        // Inicializa la conexión hacia la BBDD //
        public Operaciones_Registro_Academico()
        {
            Instancia_BBDD = new ConexionBBDD();
        }

        #region CRUD : Controlador Estudiante 
        // Devuelve la lista total de todos los Estuches //
        public dynamic Devolver_Lista_Todos_Estudiantes(int Bandera = 1, int ID_Estudiante = 0)
        {
            if (Instancia_BBDD.Abrir_Conexion_BBDD() == true)
            {
                CMD = new SqlCommand("I_Listado_Estudiantes", Instancia_BBDD.Conexion);
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.Add("@ID_Estudiante", SqlDbType.Int).Value = ID_Estudiante;
                CMD.Parameters.Add("@Bandera", SqlDbType.Bit).Value = Bandera;
                SqlReader = CMD.ExecuteReader();
                List<Estudiante> Lista_Estudiante = new List<Estudiante>();
                if (SqlReader.HasRows)
                {
                    while (SqlReader.Read())
                    {
                        Estudiante Nuevo_Estudiante = new Estudiante();
                        Nuevo_Estudiante.ID_Estudiante = SqlReader.GetInt32(0);
                        Nuevo_Estudiante.Nombre = SqlReader.GetString(1);
                        Nuevo_Estudiante.Apellido = SqlReader.GetString(2);
                        Nuevo_Estudiante.Correo = SqlReader.GetString(3);
                        Nuevo_Estudiante.Fecha_Nacimiento = SqlReader.GetDateTime(4);
                        Nuevo_Estudiante.Tutor_Nombre = SqlReader.GetString(5);
                        Nuevo_Estudiante.Tutor_Apellido = SqlReader.GetString(6);
                        Nuevo_Estudiante.Cedula = SqlReader.GetString(7);
                        Nuevo_Estudiante.Telefono_1 = SqlReader.GetDecimal(8);
                        Nuevo_Estudiante.Telefono_2 = SqlReader.GetDecimal(9);
                        Nuevo_Estudiante.Direccion = SqlReader.GetString(10);
                        Nuevo_Estudiante.Sexo = SqlReader.GetString(11);
                        Nuevo_Estudiante.Foto = SqlReader.GetString(12);
                        Nuevo_Estudiante.Rol = SqlReader.GetString(13);
                        Nuevo_Estudiante.Ano_Ingreso = SqlReader.GetDateTime(14);
                        Nuevo_Estudiante.ID_Beca = SqlReader.GetInt32(15);

                        Lista_Estudiante.Add(Nuevo_Estudiante);
                    }

                    CMD.Dispose();
                    Instancia_BBDD.Cerrar_Conexion();
                    return JsonConvert.SerializeObject(Lista_Estudiante, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                }
                else
                {
                    return "{\"Cod_Resultado\": 0,\"Mensaje\": \"La consulta no devolvio resultados\"}";
                }
            }
            else
            {
                return "{\"Cod_Resultado\": -1,\"Mensaje\": \"No se pudo conectar con la base de datos\"}";
            }
        }

        // Inserta un Estuche dado su modelo //
        public string Insertar_Estudiante(Estudiante Inst)
        {
            if (Instancia_BBDD.Abrir_Conexion_BBDD() == true)
            {
                CMD = new SqlCommand("I_Insertar_Estudiante", Instancia_BBDD.Conexion);
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.Add("@ID_Estudiante", SqlDbType.Int).Value = Inst.ID_Estudiante;
                CMD.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Inst.Nombre;
                CMD.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Inst.Apellido;
                CMD.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Inst.Correo;
                CMD.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = Inst.Fecha_Nacimiento;
                CMD.Parameters.Add("@Tutor_Nombre", SqlDbType.VarChar).Value = Inst.Tutor_Nombre;
                CMD.Parameters.Add("@Tutor_Apellido", SqlDbType.VarChar).Value = Inst.Tutor_Apellido;
                CMD.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Inst.Cedula;
                CMD.Parameters.Add("@Telefono_1", SqlDbType.Decimal).Value = Inst.Telefono_1;
                CMD.Parameters.Add("@Telefono_2", SqlDbType.Decimal).Value = Inst.Telefono_2;
                CMD.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Inst.Direccion;
                CMD.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = Inst.Sexo;
                CMD.Parameters.Add("@Foto", SqlDbType.VarChar).Value = Inst.Foto;
                CMD.Parameters.Add("@Rol", SqlDbType.VarChar).Value = Inst.Rol;
                CMD.Parameters.Add("@Año_Ingreso", SqlDbType.Date).Value = Inst.Ano_Ingreso;
                CMD.Parameters.Add("@ID_Beca", SqlDbType.Int).Value = Inst.ID_Beca;

                CMD.ExecuteNonQuery();
                CMD.Dispose();
                Instancia_BBDD.Cerrar_Conexion();
                return "{\"Cod_Resultado\": 1,\"Mensaje\": \"Se inserto el nuevo registro\"}";
            }
            else
            {
                return "{\"Cod_Resultado\": -1,\"Mensaje\": \"No se pudo conectar con la base de datos\"}";
            }
        }

        // Elimina un Estuche dado su identificador //
        public string Eliminar_Estudiante(int Id)
        {
            if (Instancia_BBDD.Abrir_Conexion_BBDD() == true)
            {
                CMD = new SqlCommand("I_Eliminar_Estudiante", Instancia_BBDD.Conexion);
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.Add("@ID_Estudiante", SqlDbType.Int).Value = Id;
                CMD.ExecuteNonQuery();
                CMD.Dispose();
                Instancia_BBDD.Cerrar_Conexion();
                return "{\"Cod_Resultado\": 1,\"Mensaje\": \"Se ha eliminado el Estudiante\"}";
            }
            else
            {
                return "{\"Cod_Resultado\": -1,\"Mensaje\": \"No se pudo conectar con la base de datos\"}";
            }
        }

        // Actualiza un Estuche dado su modelo //
        public string Actualizar_Estudiante(Estudiante Inst)
        {
            if (Instancia_BBDD.Abrir_Conexion_BBDD() == true)
            {
                CMD = new SqlCommand("I_Actualizar_Estudiante", Instancia_BBDD.Conexion);
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.Parameters.Add("@ID_Estudiante", SqlDbType.Int).Value = Inst.ID_Estudiante;
                CMD.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Inst.Nombre;
                CMD.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = Inst.Apellido;
                CMD.Parameters.Add("@Correo", SqlDbType.VarChar).Value = Inst.Correo;
                CMD.Parameters.Add("@Fecha_Nacimiento", SqlDbType.Date).Value = Inst.Fecha_Nacimiento;
                CMD.Parameters.Add("@Tutor_Nombre", SqlDbType.VarChar).Value = Inst.Tutor_Nombre;
                CMD.Parameters.Add("@Tutor_Apellido", SqlDbType.VarChar).Value = Inst.Tutor_Apellido;
                CMD.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = Inst.Cedula;
                CMD.Parameters.Add("@Telefono_1", SqlDbType.Decimal).Value = Inst.Telefono_1;
                CMD.Parameters.Add("@Telefono_2", SqlDbType.Decimal).Value = Inst.Telefono_2;
                CMD.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = Inst.Direccion;
                CMD.Parameters.Add("@Sexo", SqlDbType.VarChar).Value = Inst.Sexo;
                CMD.Parameters.Add("@Foto", SqlDbType.VarChar).Value = Inst.Foto;
                CMD.Parameters.Add("@Rol", SqlDbType.VarChar).Value = Inst.Rol;
                CMD.Parameters.Add("@Año_Ingreso", SqlDbType.Date).Value = Inst.Ano_Ingreso;
                CMD.Parameters.Add("@ID_Beca", SqlDbType.Int).Value = Inst.ID_Beca;

                CMD.ExecuteNonQuery();
                CMD.Dispose();
                Instancia_BBDD.Cerrar_Conexion();
                return "{\"Cod_Resultado\": 1,\"Mensaje\": \"Se actualizo correctamente el registro\"}";
            }
            else
            {
                return "{\"Cod_Resultado\": -1,\"Mensaje\": \"No se pudo conectar con la base de datos\"}";
            }
        }
        #endregion


    }
}