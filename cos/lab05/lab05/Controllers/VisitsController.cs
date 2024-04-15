using Microsoft.AspNetCore.Mvc;
using lab05.Database;
using lab05.Models;

namespace lab05.Controllers;
[ApiController]
[Route("/visit-controller")]
//[Route("[controller]")]
public class VisitsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetVisits(int id)
    {
        return Ok(StaticData.getVisitsById(id));
    }
    
    [HttpPost]
    public IActionResult AddVisit(String date, int id, String brief, double cost)
    {
        StaticData.addNewVisit(date, StaticData.findByid(id), brief, cost);
        return Ok("U added new visit !! d-_-b");
    }
}