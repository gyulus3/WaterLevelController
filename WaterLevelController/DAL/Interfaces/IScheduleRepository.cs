using WaterLevelController.DAL.EfDbContext;

namespace WaterLevelController.DAL.Interfaces
{
    public interface IScheduleRepository : IBaseRepository<Schedule>
    {
        public Schedule AddSensorToScheduleById(Sensor sensor, int scheduleId);
        public Schedule RemoveSensorFromSchedule(Sensor sensor, int? scheduleId);
    }
}
