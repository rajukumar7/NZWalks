using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    // https://localhost:portnumber/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        // GET All Regions
        // GET : https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland Region",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/18915012/pexels-photo-18915012/free-photo-of-dandelion.jpeg?auto=compress&cs=tinysrgb&w=600"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegionImageUrl = "https://images.pexels.com/photos/28863766/pexels-photo-28863766/free-photo-of-stunning-view-of-castlepoint-lighthouse-new-zealand.jpeg?auto=compress&cs=tinysrgb&w=600"
                }
            };
            return Ok(regions);
        }
    }
}
