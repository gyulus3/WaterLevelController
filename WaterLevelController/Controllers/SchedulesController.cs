using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WaterLevelController.Controllers.Dto;
using WaterLevelController.Services;

namespace WaterLevelController.Controllers
{
    [Route("api/schedules")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        readonly ScheduleManager scheduleManager;
        public SchedulesController(ScheduleManager scheduleManager)
        {
            this.scheduleManager = scheduleManager;
        }
        [HttpGet]
        public IEnumerable<DtoScheduleListItem> List()
        {
            return scheduleManager.GetAllSchedules();
        }

        [HttpPost]
        public ActionResult<DtoCreateSchedule> Create([FromBody] DtoCreateSchedule value)
        {
            var created = scheduleManager.AddNewSchedule(value);
            if (created != null)
                return Ok(created);
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public ActionResult<DtoCreateSchedule> Delete([FromRoute] int id)
        {
            var deleted = scheduleManager.DeleteSchedule(id);
            if (deleted != null)
                return Ok(deleted);
            return BadRequest();
        }

        [HttpPut]
        public ActionResult<DtoEditSchedule> Edit([FromBody] DtoEditSchedule value)
        {
            var edited = scheduleManager.EditSchedule(value);
            if (edited != null)
                return Ok(edited);
            return BadRequest();
        }
    }
}
