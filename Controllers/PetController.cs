using Microsoft.AspNetCore.Mvc;
using AspApiDemo.Models;

namespace AspApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        [HttpGet("{id}")]
        public Pet Get(long Id)
        {
            Pet somePet = new Pet();
            somePet.Name = "Fluffy";
            somePet.PhotoUrls = new string[]{"img"};
            return somePet;
        }

    }
}