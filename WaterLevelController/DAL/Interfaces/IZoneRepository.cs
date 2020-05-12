using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.DAL.EfDbContext;

namespace WaterLevelController.DAL.Interfaces
{
    public interface IZoneRepository : IBaseRepository<Zone>
    {
        public IEnumerable<Sensor> GetSensorsByZoneId(int id);
        public Zone AddSensorToZoneById(Sensor sensor, int zoneId);
    }
}
