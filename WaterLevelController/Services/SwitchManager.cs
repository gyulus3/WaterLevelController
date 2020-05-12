using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.Controllers.Dto;
using WaterLevelController.Controllers.Dto.DtoEdit;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;

namespace WaterLevelController.Services
{
    public class SwitchManager
    {
        private readonly ISwitchRepository switchRepository;
        private readonly ISensorRepository sensorRepository;

        public SwitchManager(ISwitchRepository switchRepository,
                                ISensorRepository sensorRepository)
        {
            this.switchRepository = switchRepository;
            this.sensorRepository = sensorRepository;
        }

        public IEnumerable<DtoSwitchListItem> GetAllSwitches()
        {
            IEnumerable<Switch> switches = switchRepository.List();
            List<DtoSwitchListItem> dtoSwitches = new List<DtoSwitchListItem>();
            string nameOfSensor;
            foreach (var s in switches)
            {
                nameOfSensor = string.Empty;
                if (s.Sensor != null)
                    nameOfSensor = s.Sensor.Name;

                dtoSwitches.Add(new DtoSwitchListItem()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Mac = s.Mac,
                    Ip = s.Ip,
                    SensorName = nameOfSensor
                });
            }
            return dtoSwitches;
        }
        public DtoEditSwitch DeleteSwitch(int switchId)
        {
            var dbSwitch = switchRepository.Delete(switchId);

            if (dbSwitch == null)
                return null;          

            return new DtoEditSwitch()
            {
                Id = dbSwitch.Id,
                Name = dbSwitch.Name,
                Mac = dbSwitch.Mac,
                Ip = dbSwitch.Ip
            };
        }
        public DtoCreateSwitch AddNewSwitch(DtoCreateSwitch swtich)
        {
            var dbSwitch = switchRepository.Insert(new Switch()
            {
                Name = swtich.Name,
                Ip = swtich.Ip,
                Mac = swtich.Mac
            });
            if (dbSwitch == null)
                return null;
            return new DtoCreateSwitch()
            {
                Name = dbSwitch.Name,
                Ip = dbSwitch.Ip,
                Mac = dbSwitch.Mac
            };
        }
        public DtoEditSwitch EditSwitch(DtoEditSwitch _switch)
        {
            var dbSwitch = switchRepository.Update(new Switch()
            {
                Id = _switch.Id,
                Name = _switch.Name,
                Ip = _switch.Ip,
                Mac = _switch.Mac
            });

            if (dbSwitch == null)
                return null;

            return new DtoEditSwitch()
            {
                Id = _switch.Id,
                Name = _switch.Name,
                Ip = _switch.Ip,
                Mac = _switch.Mac
            };
        }

        public IEnumerable<DtoSwitchListItem> GetUnusedSwitches(int sensorId)
        {
            IEnumerable<Switch> switches = switchRepository.GetUnusedSwitches(sensorId);
            List<DtoSwitchListItem> dtoSwitches = new List<DtoSwitchListItem>();

            string nameOfSensor = string.Empty;
            foreach (var s in switches)
            {
                nameOfSensor = string.Empty;
                if (s.Sensor != null)
                    nameOfSensor = s.Sensor.Name;

                dtoSwitches.Add(new DtoSwitchListItem()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Mac = s.Mac,
                    Ip = s.Ip,
                    SensorName = nameOfSensor
                });
            }
            return dtoSwitches;
        }
    }

}
