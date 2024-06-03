using Microsoft.AspNetCore.Mvc;

namespace FC.ClickVende.API.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : ControllerBase
    {
        [HttpPost]
        public IActionResult CriarClient ([FromBody] ClientDTO clientDto)
        {
            return Ok();
        }

        
    }
}
