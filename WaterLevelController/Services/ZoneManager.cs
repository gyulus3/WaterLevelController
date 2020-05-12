using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using WaterLevelController.Controllers.Dto;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;

namespace WaterLevelController.Services
{
    public class ZoneManager
    {
        private readonly IZoneRepository zoneRepository;

        public ZoneManager(IZoneRepository zoneRepository)
        {
            this.zoneRepository = zoneRepository;
        }

        public IEnumerable<DtoZoneListItem>  GetAllZones()
        {
            IEnumerable<Zone> zones = zoneRepository.List();
            List<DtoZoneListItem> dtoZones = new List<DtoZoneListItem>();
            foreach(var z in zones)
                dtoZones.Add(ZoneToDtoZone(z));

            return dtoZones;
        }
        public DtoZoneListItem AddNewZone(DtoCreateZone zone)
        {
            var created = zoneRepository.Insert(new Zone() { Name = zone.Name });
            return ZoneToDtoZone(created);
        }

        public DtoZoneListItem DeleteZone(int zoneId)
        {
            var deleted = zoneRepository.Delete(zoneId);
            return ZoneToDtoZone(deleted);
        }
        public DtoZoneListItem EditZone(DtoZoneListItem zone)
        {
            var edited = zoneRepository.Update(DtoZoneToZone(zone));
            return ZoneToDtoZone(edited);
        }

        public IEnumerable<DtoSensorListItem> ListAllSensorsByZoneId(int zoneId)
        {
            IEnumerable<Sensor> sensors = zoneRepository.GetSensorsByZoneId(zoneId);
            if(sensors == null)
                return null;
            List<DtoSensorListItem> dtoSensorListItems = new List<DtoSensorListItem>();
            foreach (var s in sensors)
                dtoSensorListItems.Add(new DtoSensorListItem()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Ip = s.Ip,
                    Mac = s.Mac,
                    Data = s.Data,
                    ScheduleName = s.Schedule.Name,
                    SwitchName = s.Switch.Name
                });

            return dtoSensorListItems;
        }

        private Zone DtoZoneToZone(DtoZoneListItem zone)
        {
            if (zone == null)
                return null;
            return new Zone() { Id = zone.Id, Name = zone.Name };
        }

        private DtoZoneListItem ZoneToDtoZone(Zone zone)
        {
            if (zone == null)
                return null;
            return new DtoZoneListItem() { Id = zone.Id, Name = zone.Name };
        }
    }
}
