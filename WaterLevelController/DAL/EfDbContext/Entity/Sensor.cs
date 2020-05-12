using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelController.DAL.EfDbContext
{
    public class Sensor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Mac { get; set; }
        [Required]
        public string Ip { get; set; }
        public int Data { get; set; }
        public int? SwitchId { get; set; }
        public virtual Switch Switch { get; set; }
        public int? ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }
        public int? ZoneId { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
