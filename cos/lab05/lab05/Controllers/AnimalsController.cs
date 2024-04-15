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
        return Ok("U added new animal !! d-_-b");
    }

    [HttpPut]
    public IActionResult EditAnimals(int id, String name, String category, double weight, String color)
    {
        StaticData.findByid(id).category = category;
        StaticData.findByid(id).name = name;
        StaticData.findByid(id).weight = weight;
        StaticData.findByid(id).color = color;
        return Ok();
    }
    

    [HttpDelete]
    public IActionResult DeleteAnimal(int id)
    {
        StaticData.removeByid(id);
        return Ok("U deleted an animal ! d-_-b");
    }

}