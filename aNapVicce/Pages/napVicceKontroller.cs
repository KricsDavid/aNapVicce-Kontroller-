using Microsoft.AspNetCore.Mvc;

namespace aNapVicce.Pages
{
    [Route("api/[controller]")]
    [ApiController]
    public class napVicceKontroller : Controller
    {
        public IActionResult Napvicce()
        {
            return Ok("Vicc");
        }
    }
}
