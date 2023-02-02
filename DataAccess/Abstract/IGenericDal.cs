using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDal <T>
    {
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        List<T> GetList();
        T GetById(int id);
    }
}
