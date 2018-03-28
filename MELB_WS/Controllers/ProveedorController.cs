using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using MELB_WS.Models.Inventario.Operaciones;

namespace MELB_WS.Controllers
{
    public class ProveedorController : ApiController
    {
        Operaciones_Inventario Instancia_OP = new Operaciones_Inventario();

        [SwaggerOperation("GetAll")]
        public string Get()
        {
            return Instancia_OP.Devolver_Lista_Todos_Proveedores();
        }


        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }

    }
}