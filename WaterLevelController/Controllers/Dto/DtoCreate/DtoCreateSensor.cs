using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelController.Controllers.Dto
{
    public class DtoCreateSensor
    {
        public string Name { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
    }
}
