using Castle.Core.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.Controllers.Dto;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;

namespace WaterLevelController.Services
{
    public class SensorManager
    {
        private readonly ISensorRepository sensorRepository;
        private readonly IZoneRepository zoneRepository;
        private readonly IScheduleRepository scheduleRepository;
        private readonly ISwitchRepository switchRepository;

        public SensorManager(ISensorRepository sensorRepository,
                                IZoneRepository zoneRepository,
                                IScheduleRepository scheduleRepository,
                                ISwitchRepository switchRepository)
        {
            this.sensorRepository = sensorRepository;
            this.zoneRepository = zoneRepository;
            this.switchRepository = switchRepository;
            this.scheduleRepository = scheduleRepository;
        }
        public IEnumerable<DtoSensorListItemWithZone> GetAllSensors()
        {
            IEnumerable<Sensor> sensors = sensorRepository.List();
            List<DtoSensorListItemWithZone> dtoSensors = new List<DtoSensorListItemWithZone>();

            foreach (var s in sensors)
            {
                dtoSensors.Add(SensorToDtoModel(s));
            }
            return dtoSensors;
        }

        public DtoEditSensor EditSensor(DtoEditSensor value)
        {
            var dbSensor = sensorRepository.Update(new Sensor()
            {
                Id = value.Id,
                Ip = value.Ip,
                Name = value.Name,
                Mac = value.Mac
            });

            if (dbSensor == null)
                return null;

            if (value.ScheduleId == 0)
            {
                scheduleRepository.RemoveSensorFromSchedule(dbSensor, dbSensor.ScheduleId);
                sensorRepository.RemoveScheduleFromSensor(value.Id);
                dbSensor.ScheduleId = null;
            }

            else
                if (AddScheduleToSensor(value.Id, value.ScheduleId) != null)
                     scheduleRepository.AddSensorToScheduleById(dbSensor, value.ScheduleId);
        
            if(value.ZoneId == 0)
            {
                zoneRepository.RemoveSensorFromZone(dbSensor, dbSensor.ZoneId);
                sensorRepository.RemoveZoneFromSensor(value.Id);
                dbSensor.ZoneId = null;
            }

            else
                if (value.ZoneId != 0)
                    if (AddZoneToSensor(value.Id, value.ZoneId) != null)
                        zoneRepository.AddSensorToZoneById(dbSensor, value.ZoneId);

            if(value.SwitchId == 0)
            {
                switchRepository.RemoveSensorFromSwitch(dbSensor, dbSensor.SwitchId);
                sensorRepository.RemoveSwitchFromSensor(value.Id);
                dbSensor.SwitchId = null;
            }

            else
                if (AddSwitchToSensor(value.Id, value.SwitchId) != null)
                     switchRepository.AddSensorToSwitchById(dbSensor, value.SwitchId);


            return new DtoEditSensor()
            {
                Id = dbSensor.Id,
                Ip = dbSensor.Ip,
                Name = dbSensor.Name,
                Mac = dbSensor.Mac
            };
        }


        public DtoEditSensor DeleteSensor(int sensorId)
        {
            var dbSensor = sensorRepository.Delete(sensorId);
            if (dbSensor == null)
                return null;

            return new DtoEditSensor()
            {
                Id = dbSensor.Id,
                Name = dbSensor.Name,
                Ip = dbSensor.Ip,
                Mac = dbSensor.Mac
            };
        }
    
        public DtoCreateSensor AddNewSensor(DtoCreateSensor sensor)
        {
            var dbSensor = sensorRepository.Insert(new Sensor()
            {
                Name = sensor.Name,
                Ip = sensor.Ip,
                Mac = sensor.Mac
            });
            if (dbSensor == null)
                return null;
            return new DtoCreateSensor()
            {
                Name = dbSensor.Name,
                Ip = dbSensor.Ip,
                Mac = dbSensor.Mac
            };
        }

        public DtoSensorListItemWithZone AddZoneToSensor(int sensorId, int zoneId)
        {
            var dbZone = zoneRepository.GetById(zoneId);
            if(dbZone == null)
                return null;
            var dbSensor = sensorRepository.AddZoneToSensor(dbZone, sensorId);

            return SensorToDtoModel(dbSensor);
        }



        public DtoSensorListItemWithZone AddSwitchToSensor(int sensorId, int switchId)
        {
            var dbSwitch = switchRepository.GetById(switchId);
            if (dbSwitch == null)
                return null;
            var dbSensor = sensorRepository.AddSwitchToSensor(dbSwitch, sensorId);

            return SensorToDtoModel(dbSensor);
        }

        public DtoSensorListItemWithZone AddScheduleToSensor(int sensorId, int scheduleId)
        {
            var dbSchedule = scheduleRepository.GetById(scheduleId);
            if (dbSchedule == null)
                return null;
            var dbSensor = sensorRepository.AddScheduleToSensor(dbSchedule, sensorId);

            return SensorToDtoModel(dbSensor);
        }


        private DtoSensorListItemWithZone SensorToDtoModel(Sensor sensor)
        {
            string nameOfZone = string.Empty;
            string nameOfSwitch = string.Empty;
            string nameOfSchedule = string.Empty;

            if (sensor.Zone != null)
                nameOfZone = sensor.Zone.Name;

            if (sensor.Switch != null)
                nameOfSwitch = sensor.Switch.Name;

            if (sensor.Schedule != null)
                nameOfSchedule = sensor.Schedule.Name;

            return new DtoSensorListItemWithZone()
            {
                Id = sensor.Id,
                Name = sensor.Name,
                Ip = sensor.Ip,
                Mac = sensor.Mac,
                Data = sensor.Data,
                ZoneName = nameOfZone,
                ScheduleName = nameOfSchedule,
                SwitchName = nameOfSwitch
            };
        }
    }
}
