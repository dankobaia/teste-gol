using AirplaneCrud.API.Models;
using AirplaneCrud.Domain;
using AirplaneCrud.Domain.Models.Airplane;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AirplaneCrud.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : ControllerBase
    {
        private readonly IAirplaneDomain airplaneDomain;

        public AirplaneController(IAirplaneDomain airplaneDomain)
        {
            this.airplaneDomain = airplaneDomain;
        }

        // GET api/values
        [HttpGet]
        public Task<IEnumerable<IAirplane>> Get([FromQuery] int limit = 20, int offset = 0)
        {
            return airplaneDomain.List(limit, offset);
        }

        // POST api/values
        [HttpPost]
        public Task<IAirplane> PostAsync([FromBody] CreateAirplane value)
        {
            return airplaneDomain.Create(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Task<IAirplane> Put(string id, [FromBody] CreateAirplane value)
        {
            return airplaneDomain.Edit(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Task Delete(string id)
        {
            Response.StatusCode = 204;
            return airplaneDomain.Remove(id);
        }
    }
}