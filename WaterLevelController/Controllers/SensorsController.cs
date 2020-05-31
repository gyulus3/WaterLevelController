using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WaterLevelController.Controllers.Dto;
using WaterLevelController.Services;

namespace WaterLevelController.Controllers
{
    [Route("api/sensors")]
    [ApiController]
    public class SensorsController : ControllerBase
    {
        readonly SensorManager sensorManager;
        public SensorsController(SensorManager sensorManager)
        {
            this.sensorManager = sensorManager;
        }

        [HttpGet]
        public IEnumerable<DtoSensorListItemWithZone> List()
        {
            return sensorManager.GetAllSensors();
        }

        [HttpPost]
        public ActionResult<DtoCreateSensor> Create([FromBody] DtoCreateSensor value)
        {
            var created = sensorManager.AddNewSensor(value);
            if (created != null)
                return Ok(created);
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public ActionResult<DtoCreateZone> Delete([FromRoute] int id)
        {
            var deleted = sensorManager.DeleteSensor(id);
            if (deleted != null)
                return Ok(deleted);
            return BadRequest();
        }

        [HttpPut]
        public ActionResult<DtoEditSensor> Edit([FromBody] DtoEditSensor value)
        {
            var edited = sensorManager.EditSensor(value);
            if (edited != null)
                return Ok(edited);
            return BadRequest("Can not updated.");
        }

    }
}
