using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParksApi.Controllers
{
    public class ParksController : ControllerBase
    {
        [HttpGet("/parks")]
        public async Task<ActionResult<CollectionResult<ParkListItemModel>>> GetAllParks()
        {
            // go to the database and all that jazz
            var response = new CollectionResult<ParkListItemModel>
            {
                Data = new List<ParkListItemModel>
                {
                    new ParkListItemModel{ Id= 1, Description = "Grant Park", Address="Mayfield Heights",OpenInformation ="Year Round, Closes at Dusk"},
                    new ParkListItemModel { Id =2, Description = "Wilderness Preserve", Address ="Mentor", OpenInformation= "Year Round, Permit Needed"}
                }
            };
            return Ok(response);
        }
    }

    public class CollectionResult<T>
    {
        public IList<T> Data { get; set; }
    }
    public class ParkListItemModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string OpenInformation { get; set; }
    }
}
