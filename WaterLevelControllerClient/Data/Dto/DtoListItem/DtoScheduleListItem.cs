using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelControllerClient.Data.Dto
{
    public class DtoScheduleListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinWaterLevel { get; set; }
        public bool Auto { get; set; }
        public int NumberOfSensors { get; set; }
    }
}
