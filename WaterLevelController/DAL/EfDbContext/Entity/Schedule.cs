using System.Collections.Generic;

namespace WaterLevelController.DAL.EfDbContext
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinWaterLevel { get; set; }
        public bool Auto { get; set; }
        public virtual ICollection<Sensor> Sensors { get; set; }
    }
}
