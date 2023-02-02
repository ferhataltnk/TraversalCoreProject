using DataAccess.Abstract;
using DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T item)
        {
            using var c = new TraversalContext();
            c.Remove(item);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new TraversalContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new TraversalContext();
            return c.Set<T>().ToList();

        }

        public void Insert(T item)
        {
            using var c = new TraversalContext();
            c.Add(item);
        }

        public void Update(T item)
        {
            using var c = new TraversalContext();
            c.Update(item);

        }
    }
}
