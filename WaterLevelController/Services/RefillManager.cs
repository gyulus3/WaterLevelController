using System.Collections.Generic;
namespace WaterLevelController.Services
{
    public static class RefillManager
    {
        private static readonly object syncObj = new object(); 
        private static List<int> refillable = new List<int>();

        public static void add(int sensorId)
        {
            lock (syncObj)
            {
                if (!refillable.Contains(sensorId))
                    refillable.Add(sensorId);
            }

        }

        public static List<int> getAll()
        {
            lock (syncObj)
            {
                return refillable;
            }

        }

        public static int getSize()
        {
            lock (syncObj)
            {
                return refillable.Count;
            }

        }

        public static void remove(int sensorId)
        {
            lock (syncObj)
            {
                refillable.Remove(sensorId);
            }

        }
    }
}
