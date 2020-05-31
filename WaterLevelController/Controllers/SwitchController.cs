using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WaterLevelController.Controllers.Dto;
using WaterLevelController.Controllers.Dto.DtoEdit;
using WaterLevelController.Services;

namespace WaterLevelController.Controllers
{
    [Route("api/switches")]
    [ApiController]
    public class SwitchController : ControllerBase
    {
        readonly SwitchManager switchManager;

        public SwitchController(SwitchManager switchManager)
        {
            this.switchManager = switchManager;
        }

        [HttpGet]
        public IEnumerable<DtoSwitchListItem> List()
        {
            return switchManager.GetAllSwitches();
        }

        [HttpGet("unusedSwitches/{id}")]
        public IEnumerable<DtoSwitchListItem> ListUnused([FromRoute] int id)
        {
            return switchManager.GetUnusedSwitches(id);
            
        }

        [HttpPost]
        public ActionResult<DtoCreateSwitch> Create([FromBody] DtoCreateSwitch value)
        {
            var created = switchManager.AddNewSwitch(value);
            if (created != null)
                return Ok(created);
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public ActionResult<DtoSwitchListItem> Delete([FromRoute] int id)
        {
            var deleted = switchManager.DeleteSwitch(id);
            if (deleted != null)
                return Ok(deleted);
            return BadRequest();
        }

        [HttpPut]
        public ActionResult<DtoEditSchedule> Edit([FromBody] DtoEditSwitch value)
        {
            var edited = switchManager.EditSwitch(value);
            if (edited != null)
                return Ok(edited);
            return BadRequest();
        }
    }
}
