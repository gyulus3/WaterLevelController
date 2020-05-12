using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;

namespace WaterLevelController.DAL.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly WaterLevelDbContext db;
        public ScheduleRepository(WaterLevelDbContext db)
        {
            this.db = db;
        }

        public Schedule AddSensorToScheduleById(Sensor sensor, int scheduleId)
        {
            var dbSchedule = db.Schedules.FirstOrDefault(s => s.Id == scheduleId);
            if (dbSchedule != null)
            {
                dbSchedule.Sensors.Add(sensor);
                db.SaveChanges();
            }
            return dbSchedule;

        }

        public Schedule Delete(int id)
        {
            var dbSchedule = db.Schedules.FirstOrDefault(s => s.Id == id);
            if (dbSchedule != null)
            {
                db.Schedules.Remove(dbSchedule);
                db.SaveChanges();
            }
            return dbSchedule;
        }

        public Schedule GetById(int id)
        {
            return db.Schedules.FirstOrDefault(s => s.Id == id);
        }

        public Schedule GetScheduleByName(string name)
        {
            return db.Schedules.FirstOrDefault(s => s.Name.ToUpper() == name.ToUpper());
        }

        public Schedule Insert(Schedule value)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                if (db.Schedules.Any(s => s.Name.ToUpper() == value.Name.ToUpper()))
                    return null;

                var toInsert = new Schedule() { Name = value.Name, MinWaterLevel = value.MinWaterLevel, Auto = value.Auto  };
                db.Schedules.Add(toInsert);

                db.SaveChanges();
                tran.Commit();

                return toInsert;
            }
        }

        public IEnumerable<Schedule> List()
        {
            return db.Schedules.ToList();
        }

        public Schedule RemoveSensorFromSchedule(Sensor sensor, int? scheduleId)
        {
            if (scheduleId == null)
                return null;
            var dbSchedule = db.Schedules.FirstOrDefault(s => s.Id == scheduleId);
            if (dbSchedule != null)
            {
                dbSchedule.Sensors.Remove(sensor);
                db.SaveChanges();
            }
            return dbSchedule;
        }

        public Schedule Update(Schedule value)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                var dbSchedule = db.Schedules.FirstOrDefault(s => s.Id == value.Id);
                if (dbSchedule != null)
                {
                    dbSchedule.Name = value.Name;
                    dbSchedule.Auto = value.Auto;
                    dbSchedule.MinWaterLevel = value.MinWaterLevel;
                    db.SaveChanges();
                }
                tran.Commit();
                return dbSchedule;
            }
        }
    }
}
