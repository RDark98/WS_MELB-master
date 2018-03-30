using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using MELB_WS.Models.Inventario.Operaciones;
using MELB_WS.Models.Inventario.Modelos;

namespace MELB_WS.Controllers
{
    public class EstudianteController : ApiController
    {
        Operaciones_Registro_Academico Instancia_OP = new Operaciones_Registro_Academico();

        // Retorno de toda la coleccion de datos //
        [SwaggerOperation("GetAll")]
        public string Get()
        {
            return Instancia_OP.Devolver_Lista_Todos_Estudiantes();
        }

        // Retorno de un registro de la coleccion de datos //
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Get(int ID)
        {
            return Instancia_OP.Devolver_Lista_Todos_Estudiantes(0, ID);
        }

        // Creacion de un nuevo registro //
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Post([FromBody]Estudiante Ins)
        {
            if (ModelState.IsValid && Ins != null)
            {
                return Instancia_OP.Insertar_Estudiante(Ins);
            }
            else
            {
                return "{\"Cod_Resultado\": -1,\"Mensaje\": \"El modelo no es correcto, asegurate de enviar bien los datos\"}";
            }
        }

        // Actualizacion de un registro ya existente //
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Put([FromBody]Estudiante Ins)
        {
            if (ModelState.IsValid && Ins != null)
            {
                return Instancia_OP.Actualizar_Estudiante(Ins);
            }
            else
            {
                return "{\"Cod_Resultado\": -1,\"Mensaje\": \"El modelo no es correcto, asegurate de enviar bien los datos\"}";
            }
        }

        // Eliminación de un registro //
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Delete(int ID)
        {
            return Instancia_OP.Eliminar_Estudiante(ID);
        }

    }
}