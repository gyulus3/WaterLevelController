using Castle.Core.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;

namespace WaterLevelController.DAL.Repositories
{
    public class SwitchRepository : ISwitchRepository
    {
        private readonly WaterLevelDbContext db;
        public SwitchRepository(WaterLevelDbContext db)
        {
            this.db = db;
        }

        public Switch Delete(int id)
        {
            var dbSwitch = db.Switches.FirstOrDefault(s => s.Id == id);
            if(dbSwitch != null)
            {
                db.Switches.Remove(dbSwitch);
                db.SaveChanges();
            }
            return dbSwitch;
        }

        public Switch GetById(int id)
        {
            return db.Switches.FirstOrDefault(s => s.Id == id);
        }

        public Switch GetSwitchByName(string name)
        {
            return db.Switches.FirstOrDefault(s => s.Name.ToUpper() == name.ToUpper());
        }

        public Switch Insert(Switch value)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                if (db.Switches.Any(s => s.Name.ToUpper() == value.Name.ToUpper()))
                    return null;
                if (db.Switches.Any(s => s.Ip.ToUpper() == value.Ip.ToUpper()))
                    return null;
                if (db.Switches.Any(s => s.Mac.ToUpper() == value.Mac.ToUpper()))
                    return null;

                var toInsert = new Switch() { Name = value.Name, Ip = value.Ip, Mac = value.Mac };
                db.Switches.Add(toInsert);

                db.SaveChanges();
                tran.Commit();

                return toInsert;
            }
        }

        public IEnumerable<Switch> List()
        {
            return db.Switches.ToList();
        }

        public Switch Update(Switch value)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                var dbSwitch = db.Switches.FirstOrDefault(s => s.Id == value.Id);
                if (dbSwitch == null)
                    return null;

                dbSwitch.Name = value.Name;
                dbSwitch.Ip = value.Ip;
                dbSwitch.Mac = value.Mac;
                db.SaveChanges();
                tran.Commit();
                return dbSwitch;
            }
        }

        public Switch AddSensorToSwitchById(Sensor sensor, int switchId)
        {
            var dbSwitch = db.Switches.FirstOrDefault(s => s.Id == switchId);
            if (dbSwitch != null)
            {
                dbSwitch.Sensor = sensor;
                db.SaveChanges();

            }
            return dbSwitch;
        }

        public IEnumerable<Switch> GetUnusedSwitches(int sensorId)
        {
            IEnumerable<Switch> all = db.Switches.ToList();
            List<Switch> unused = new List<Switch>();
            foreach(var sw in all)
                if (sw.Sensor == null || sw.Sensor.Id == sensorId)
                    unused.Add(sw);
            return unused;
        }
    }
}
