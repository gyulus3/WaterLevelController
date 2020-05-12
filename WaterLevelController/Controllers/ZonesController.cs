using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterLevelController.Controllers.Dto;
using WaterLevelController.Services;

namespace WaterLevelController.Controllers
{
    
    [Route("api/zones")]
    [ApiController]
    public class ZonesController : ControllerBase
    {
        ZoneManager zoneManager;
        public ZonesController(ZoneManager zoneManager)
        {
            this.zoneManager = zoneManager;
        }

        [HttpGet]
        public IEnumerable<DtoZoneListItem> List()
        {
            return zoneManager.GetAllZones();
        }

        [HttpPost]
        public ActionResult<DtoCreateZone> Create([FromBody] DtoCreateZone value)
        {
            var created = zoneManager.AddNewZone(value);
            if (created != null)
                return Ok(created);
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public ActionResult<DtoCreateZone> Delete([FromRoute] int id)
        {
            var deleted = zoneManager.DeleteZone(id);
            if (deleted != null)
                return Ok(deleted);
            return BadRequest();
        }

        [HttpGet("sensors/{id}")]
        public IEnumerable<DtoSensorListItem> ListSensors([FromRoute] int id)
        {
            return zoneManager.ListAllSensorsByZoneId(id);
        }

        [HttpPut]
        public ActionResult<DtoZoneListItem> Edit([FromBody] DtoZoneListItem value)
        {
            var edited = zoneManager.EditZone(value);
            if (edited != null)
                return Ok(edited);
            return BadRequest();
        }

    }
}
