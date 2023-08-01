using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessRUs.Data;
using ProcessRUs.Entities;
using ProcessRUs.Helpers;
using ProcessRUs.Interfaces;
using System.Security.Claims;

namespace ProcessRUs.Controllers
{
    [Route("api/v1/access")]
    [Authorize(Roles = "Admin,BackOffice")]
    [ApiController]
    public class AccessController : Controller
    {
        private readonly IFruitService _fruitService;

        public AccessController(IFruitService fruitService)
        {
            _fruitService = fruitService;
        }

        [HttpGet("fruit")]
        public ActionResult<IEnumerable<Fruit>> GetFruits(FruitType type)
        {
            var fruits = _fruitService.GetFruits(type);
            return Ok(fruits);
        }                
    }
}
