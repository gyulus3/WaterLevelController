using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.Controllers.Dto;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;

namespace WaterLevelController.Services
{
    public class ScheduleManager
    {
        private readonly IScheduleRepository scheduleRepository;
        public ScheduleManager(IScheduleRepository scheduleRepository)
        {
            this.scheduleRepository = scheduleRepository;
        }

        public IEnumerable<DtoScheduleListItem> GetAllSchedules()
        {
            IEnumerable<Schedule> schedules = scheduleRepository.List();
            List<DtoScheduleListItem> dtoSchedules = new List<DtoScheduleListItem>();
            foreach (var s in schedules)
                dtoSchedules.Add(new DtoScheduleListItem()
                {
                    Id = s.Id,
                    Name = s.Name,
                    MinWaterLevel = s.MinWaterLevel,
                    Auto = s.Auto,
                    NumberOfSensors = s.Sensors.Count
                }) ;
            

            return dtoSchedules;
        }

        public DtoScheduleListItem DeleteSchedule(int scheduleId)
        {
            var dbSchedule = scheduleRepository.Delete(scheduleId);
            if (dbSchedule == null)
                return null;

            return new DtoScheduleListItem()
            {
                Id = dbSchedule.Id,
                Name = dbSchedule.Name,
                MinWaterLevel = dbSchedule.MinWaterLevel,
                Auto = dbSchedule.Auto,
                NumberOfSensors = dbSchedule.Sensors.Count
            };
        }

        public DtoCreateSchedule AddNewSchedule(DtoCreateSchedule schedule)
        {
            var dbSchedule = scheduleRepository.Insert(new Schedule()
            {
                Name = schedule.Name,
                MinWaterLevel = schedule.MinWaterLevel,
                Auto = schedule.Auto
            });
            if (dbSchedule == null)
                return null;
            return new DtoCreateSchedule()
            {
                Name = dbSchedule.Name,
                MinWaterLevel = dbSchedule.MinWaterLevel,
                Auto = dbSchedule.Auto
            };
        }

        public DtoEditSchedule EditSchedule(DtoEditSchedule schedule)
        {
            var dbSchedule = scheduleRepository.Update(new Schedule()
            {
                Id = schedule.Id,
                MinWaterLevel = schedule.MinWaterLevel,
                Name = schedule.Name,
                Auto = schedule.Auto
            });

            if (dbSchedule == null)
                return null;

            return new DtoEditSchedule()
            {
                Id = dbSchedule.Id,
                Name = dbSchedule.Name,
                MinWaterLevel = dbSchedule.MinWaterLevel,
                Auto = dbSchedule.Auto
            };
        }
    }
}
