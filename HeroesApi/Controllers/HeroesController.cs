using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using HeroesApi.Models;
using HeroesApi.Data;
namespace HeroesApi.Controllrs;

[ApiController]
[Route("api/[controller]")]
public class HeroesController : ControllerBase { }
[HttpGet]
public ActionResult<List<Hero>> GetAll() {
    return Ok(HeroesStore.Heroes);
}
