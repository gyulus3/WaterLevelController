using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelController.Controllers.Dto
{
    public class DtoCreateSchedule
    {
        public string Name { get; set; }
        public int MinWaterLevel { get; set; }
        public bool Auto { get; set; }
    }
}
