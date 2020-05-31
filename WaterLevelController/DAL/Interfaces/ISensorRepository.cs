using WaterLevelController.DAL.EfDbContext;

namespace WaterLevelController.DAL.Interfaces
{
    public interface ISensorRepository : IBaseRepository<Sensor>
    {
        public Sensor AddZoneToSensor(Zone zone, int sensorId);
        public Sensor AddSwitchToSensor(Switch _switch, int sensorId);
        public Sensor AddScheduleToSensor(Schedule schedule, int sensorId);
        public Sensor RemoveScheduleFromSensor(int sensorId);
        public Sensor RemoveZoneFromSensor(int sensorId);
        public Sensor RemoveSwitchFromSensor(int sensorId);
    }
}
