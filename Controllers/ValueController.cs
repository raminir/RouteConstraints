using Microsoft.AspNetCore.Mvc;

namespace RouteConstraints.Controllers;

[Route("api/[controller]")]
public class ValueController : Controller
{
    // GET: api/value/abcde
    //[HttpGet("{id}")]
    [HttpGet("{id:minlength(2):maxlength(10):alpha}")]
    public ActionResult Details(string id) => Ok(id);
}