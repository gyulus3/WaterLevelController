﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelController.Controllers.Dto
{
    public class DtoSensorListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public int Data { get; set; }
        public string SwitchName { get; set; }
        public string ScheduleName { get; set; }
    }
}
