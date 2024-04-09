using Microsoft.AspNetCore.Mvc;

namespace lab05.Controllers;
[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }
    
    
    [HttpGet]
    public IActionResult GetAnimals(int id)
    {
        return Ok(id);
    }

    
    [HttpGet]
    public IActionResult AddAnimals()
    {
        return Ok();
    }

}