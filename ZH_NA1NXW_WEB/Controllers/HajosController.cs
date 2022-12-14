using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZH_NA1NXW_WEB.Models;

namespace ZH_NA1NXW_WEB.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class HajosController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]

        public IActionResult hajos()
        {
            HajosContext context = new HajosContext();
            var kerdesek = from x in context.Questions
                           select x.Question1;

            return Ok(kerdesek);
        }
    }
}
