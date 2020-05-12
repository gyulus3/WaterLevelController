using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;

namespace WaterLevelController.DAL.Repositories
{
    public class SensorRepository : ISensorRepository
    {
        private readonly WaterLevelDbContext db;
        public SensorRepository(WaterLevelDbContext db)
        {
            this.db = db;
        }

        public Sensor AddScheduleToSensor(Schedule schedule, int sensorId)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                var dbSensor = db.Sensors.FirstOrDefault(s => s.Id == sensorId);
                dbSensor.Schedule = schedule;
                db.SaveChanges();
                tran.Commit();
                return dbSensor;
            }
        }

        public Sensor AddSwitchToSensor(Switch _switch, int sensorId)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                var dbSensor = db.Sensors.FirstOrDefault(s => s.Id == sensorId);
                dbSensor.Switch = _switch;
                db.SaveChanges();
                tran.Commit();
                return dbSensor;
            }
        }

        public Sensor AddZoneToSensor(Zone zone, int sensorId)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                var dbSensor = db.Sensors.FirstOrDefault(s => s.Id == sensorId);
                dbSensor.Zone = zone;
                db.SaveChanges();
                tran.Commit();
                return dbSensor;
            }
        }

        public Sensor Delete(int id)
        {
            var dbSensor = db.Sensors.FirstOrDefault(s => s.Id == id);
            if(dbSensor != null)
            {
                db.Sensors.Remove(dbSensor);
                db.SaveChanges();
            }
            return dbSensor;
        }

        public Sensor GetById(int id)
        {
            return db.Sensors.FirstOrDefault(s => s.Id == id);
        }

        public Sensor Insert(Sensor value)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                if (db.Sensors.Any(t => t.Name.ToUpper() == value.Name.ToUpper()))
                    return null;
                if (db.Sensors.Any(t => t.Mac.ToUpper() == value.Mac.ToUpper()))
                    return null;
                if (db.Sensors.Any(t => t.Ip.ToUpper() == value.Ip.ToUpper()))
                    return null;

                var toInsert = new Sensor() { Name = value.Name, Mac = value.Mac, Ip = value.Ip, };
                db.Sensors.Add(toInsert);

                db.SaveChanges();
                tran.Commit();

                return toInsert;
            }
        }

        public IEnumerable<Sensor> List()
        {
            return db.Sensors.ToList();
        }

        public Sensor RemoveScheduleFromSensor(int sensorId)
        {
            var dbSensor = db.Sensors.FirstOrDefault(s => s.Id == sensorId);
            dbSensor.Schedule = null;
            db.SaveChanges();
            return dbSensor;
        }

        public Sensor RemoveSwitchFromSensor(int sensorId)
        {
            var dbSensor = db.Sensors.FirstOrDefault(s => s.Id == sensorId);
            dbSensor.Switch = null;
            db.SaveChanges();
            return dbSensor;
        }

        public Sensor RemoveZoneFromSensor(int sensorId)
        {
            var dbSensor = db.Sensors.FirstOrDefault(s => s.Id == sensorId);
            dbSensor.Zone = null;
            db.SaveChanges();
            return dbSensor;
        }

        public Sensor Update(Sensor value)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                var dbSensor = db.Sensors.FirstOrDefault(s => s.Id == value.Id);
                if (dbSensor == null)
                    return null;

                if (db.Sensors.Any(s => s.Name.ToUpper() == value.Name.ToUpper() && s.Id != value.Id))
                    return null;
                if (db.Sensors.Any(s => s.Ip.ToUpper() == value.Ip.ToUpper() && s.Id != value.Id))
                    return null;
                if (db.Sensors.Any(s => s.Mac.ToUpper() == value.Mac.ToUpper() && s.Id != value.Id))
                    return null;

                dbSensor.Name = value.Name;
                dbSensor.Ip = value.Ip;
                dbSensor.Mac = value.Mac;

                db.Sensors.Update(dbSensor);
                db.SaveChanges();
                tran.Commit();
                return dbSensor;
            }
        }
    }
}
