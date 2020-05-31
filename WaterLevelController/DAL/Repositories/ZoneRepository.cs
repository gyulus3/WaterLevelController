using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;

namespace WaterLevelController.DAL.Repositories
{
    public class ZoneRepository : IZoneRepository
    {
        private readonly WaterLevelDbContext db;
        public ZoneRepository(WaterLevelDbContext db)
        {
            this.db = db;
        }

        public Zone AddSensorToZoneById(Sensor sensor, int zoneId)
        {
            var dbZone = db.Zones.FirstOrDefault(z => z.Id == zoneId);
            if (dbZone != null)
            {
                dbZone.Sensors.Add(sensor);
                db.SaveChanges();
            }

            return dbZone;
        }

        public Zone Delete(int id)
        {
            var dbZone = db.Zones.FirstOrDefault(z => z.Id == id);
            if(dbZone != null)
            {
                db.Zones.Remove(dbZone);
                db.SaveChanges();
            }
            return dbZone;
        }

        public Zone GetById(int id)
        {
            return db.Zones.FirstOrDefault(z => z.Id == id);
        }

        public IEnumerable<Sensor> GetSensorsByZoneId(int id)
        {
            var dbZone = db.Zones.FirstOrDefault(z => z.Id == id);
            if(dbZone != null)
                return dbZone.Sensors;
            return new List<Sensor>();
        }

        public Zone Insert(Zone value)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                if (db.Zones.Any(t => t.Name.ToUpper() == value.Name.ToUpper()))
                    return null;

                var toInsert = new Zone() { Name = value.Name };
                db.Zones.Add(toInsert);

                db.SaveChanges();
                tran.Commit();

                return toInsert;
            }
        }

        public IEnumerable<Zone> List()
        {
            return db.Zones.ToList();
        }

        public Zone RemoveSensorFromZone(Sensor sensor, int? zoneId)
        {
            if (zoneId == null)
                return null;
            var dbZone = db.Zones.FirstOrDefault(s => s.Id == zoneId);
            if (dbZone != null)
            {
                dbZone.Sensors.Remove(sensor);
                db.SaveChanges();
            }
            return dbZone;
        }

        public Zone Update(Zone value)
        {
            using (var tran = db.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
            {
                var dbZone = db.Zones.FirstOrDefault(z => z.Id == value.Id);
                if (dbZone != null)
                {
                    dbZone.Name = value.Name;
                    db.SaveChanges();
                }
                tran.Commit();
                return dbZone;
            }
        }
    }
}
