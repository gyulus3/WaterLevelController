using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelController.Modell
{
    public class Sensor
    {
        [Key]
        public int SensorId { get; set; }
        public string Name { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public Switch Switch { get; set; }
    }
}
