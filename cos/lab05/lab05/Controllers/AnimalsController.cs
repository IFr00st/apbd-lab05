using Microsoft.AspNetCore.Mvc;
using lab05.Database;
using lab05.Models;

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
    public IActionResult AddAnimals(int id, String name, String category, double weight, String color)
    {
        StaticData.Animals.Add(new Animal(id, name, category, weight, color));
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult EditAnimals(int id)
    {
        return Ok();
    }

}