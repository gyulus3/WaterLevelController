using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.DAL.EfDbContext;

namespace WaterLevelController.DAL.Interfaces
{
    public interface ISwitchRepository : IBaseRepository<Switch>
    {
        public Switch AddSensorToSwitchById(Sensor sensor, int switchId);

        public Switch RemoveSensorFromSwitch(Sensor sensor, int? switchId);

        public IEnumerable<Switch> GetUnusedSwitches(int sensorId);
    }
}
