using System.Collections.Generic;

namespace WaterLevelController.DAL.EfDbContext
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sensor> Sensors { get; set; }
    }
}
