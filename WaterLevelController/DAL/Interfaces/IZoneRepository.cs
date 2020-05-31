using System.Collections.Generic;
using WaterLevelController.DAL.EfDbContext;

namespace WaterLevelController.DAL.Interfaces
{
    public interface IZoneRepository : IBaseRepository<Zone>
    {
        public IEnumerable<Sensor> GetSensorsByZoneId(int id);

        public Zone AddSensorToZoneById(Sensor sensor, int zoneId);

        public Zone RemoveSensorFromZone(Sensor sensor, int? zoneId);

    }
}
