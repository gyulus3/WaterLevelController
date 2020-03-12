using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelController.Modell
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }
        public string Name { get; set; }
        public int MinWaterLevel { get; set; }
        public bool Auto { get; set; }
        public Switch Switch { get; set; }

    }
}
