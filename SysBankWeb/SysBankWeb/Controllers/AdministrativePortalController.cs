using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace SysBankWeb.Controllers
{
    [ApiController]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(401)]
    [ProducesResponseType(500)]
    [Route("V1/[controller]")]
    public class AdministrativePortalController : Controller
    {
        //private readonly IAdministrativePortalLogic _administrativePortalLogic;
        public AdministrativePortalController()
        {

        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ActionName("SaveUser")]
        public IActionResult SaveUser(CustomersDto loginDto)
        {
            var respuesta = "";
            return Ok(respuesta);
        }
    }
}
