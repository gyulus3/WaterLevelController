﻿namespace WaterLevelController.DAL.EfDbContext
{
    public class Switch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public virtual Sensor Sensor { get; set; }
    }
}
