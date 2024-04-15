using Microsoft.AspNetCore.Mvc;
using lab05.Database;
namespace lab05.Controllers;
[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(StaticData.Animals);
    }
    
    
    [HttpGet("{id}")]
    public IActionResult GetAnimals(int id)
    {
        return Ok(StaticData.findByid(id));
    }

    
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Ok();
    }

}