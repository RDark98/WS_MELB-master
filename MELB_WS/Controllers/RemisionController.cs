using MELB_WS.Models.Inventario.Operaciones;
using MELB_WS.Models.Registro_Academico.Modelos;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;


namespace MELB_WS.Controllers
{
    public class RemisionController : ApiController
    {

        Operaciones_Registro_Academico Instancia_OP = new Operaciones_Registro_Academico();

        // Retorno de toda la coleccion de datos //
        [SwaggerOperation("GetAll")]
        public string Get()
        {
            return Instancia_OP.Devolver_Lista_Remisiones();
        }

        // Retorno de un registro de la coleccion de datos //
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Get(int ID)
        {
            return Instancia_OP.Devolver_Lista_Remisiones(ID,0);
        }

        // Creacion de un nuevo registro //
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Post([FromBody]Remision Re)
        {
            return Instancia_OP.Insertar_Remision(Re);
        }

        // Actualizacion de un registro ya existente //
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Put([FromBody] Remision Re)
        {
            return Instancia_OP.Actualizar_Remision(Re);
        }

        // Eliminación de un registro //
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public string Delete(int ID)
        {
            return Instancia_OP.Eliminar_Remision(ID);
        }

    }
}