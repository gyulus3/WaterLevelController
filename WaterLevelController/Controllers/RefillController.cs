using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WaterLevelController.Services;


namespace WaterLevelController.Controllers
{
    [Route("api/refill")]
    [ApiController]
    public class RefillController : ControllerBase
    {
        readonly SensorManager sensorManager;
        public RefillController(SensorManager sensorManager)
        {
            this.sensorManager = sensorManager;
        }

        [HttpGet("{id}")]
        public IActionResult Refill([FromRoute] int id)
        {
            bool result = this.sensorManager.AddSensorToRefillManager(id);
            if (result)
                return Ok();
            return NotFound();
        }

        [HttpPut]
        public IActionResult RefillAll([FromBody] List<int> ids)
        {
            bool returnResult = true;
            foreach(int id in ids){
                bool result = this.sensorManager.AddSensorToRefillManager(id);
                if (!result)
                    returnResult = false;
            }
            if(returnResult)
                return Ok();
            return NotFound();

        }

    }
}
