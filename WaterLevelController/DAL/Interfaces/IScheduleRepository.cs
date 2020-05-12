using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.DAL.EfDbContext;

namespace WaterLevelController.DAL.Interfaces
{
    public interface IScheduleRepository : IBaseRepository<Schedule>
    {
        public Schedule AddSensorToScheduleById(Sensor sensor, int scheduleId);
        public Schedule RemoveSensorFromSchedule(Sensor sensor, int? scheduleId);
    }
}
