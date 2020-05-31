using System.Collections.Generic;

namespace WaterLevelController.DAL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        public IEnumerable<T> List();
        public T GetById(int id);
        public T Insert(T value);
        public T Update(T value);
        public T Delete(int id);
    }
}
