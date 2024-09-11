using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend_lab.Models;
using backend_lab.Handlers;

namespace backend_lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly PaisesHandler _paiseshandler;

        public PaisesController()
        {
            _paiseshandler = new PaisesHandler();
        }
        [HttpGet]
        public List<PaisModel> Get()
        {
            var paises = _paiseshandler.ObtenerPaises();
            return paises;
        }
    }
}
