using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    // https://localhost:portnumber/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDBContext dbContext;

        // Creating a cunstuctor for the controller
        public RegionsController(NZWalksDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET All Regions
        // GET : https://localhost:portnumber/api/regions
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    This is the hard coded list
        //    var regions = new List<Region>()
        //    {
        //        new Region
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Auckland Region",
        //            Code = "AKL",
        //            RegionImageUrl = "https://images.pexels.com/photos/18915012/pexels-photo-18915012/free-photo-of-dandelion.jpeg?auto=compress&cs=tinysrgb&w=600"
        //        },
        //        new Region
        //        {
        //            Id = Guid.NewGuid(),
        //            Name = "Wellington Region",
        //            Code = "WLG",
        //            RegionImageUrl = "https://images.pexels.com/photos/28863766/pexels-photo-28863766/free-photo-of-stunning-view-of-castlepoint-lighthouse-new-zealand.jpeg?auto=compress&cs=tinysrgb&w=600"
        //        }
        //    };
        //    return Ok(regions);

        //}


        
        // <============= # Now Result from Database using DBContext for communicato to the DB ==============>

        // GET All Regions
        // GET : https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = dbContext.Regions.ToList();

            return Ok(regions);

        }

        // GET SINGLE REGION (Get Region by ID)
        // GET : https://localhost:portnumber/api/regions/{id}
        [HttpGet]
        [Route("{id:Guid}")]
        
        public IActionResult GetById(Guid id)
        {
            // var region = dbContext.Regions.Find(id); // Find method is used to find the record by primary key

            var region = dbContext.Regions.FirstOrDefault(x => x.Id == id); // FirstOrDefault method is used to find the record by any column

            if (region == null)
            {
                return NotFound();
            }

            return Ok(region);
        }
    }
}
