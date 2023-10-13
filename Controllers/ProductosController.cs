using Microsoft.AspNetCore.Mvc;
using proyectoFinalAPI.Datos;
using proyectoFinalAPI.Modelo;

namespace proyectoFinalAPI.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController
    {
        [HttpGet]
        public async Task <ActionResult<List<ModeloProductos>>> Get()
        {
            var funcion = new DatosProductos();
            var lista = await funcion.MostrarProductos();
            return lista;
        }
    }
}
