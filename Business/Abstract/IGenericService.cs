using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<TEntity>
    {
        void TAdd(TEntity tEntity);
        void TDelete(TEntity tEntity);
        void TUpdate(TEntity tEntity);
        List<TEntity> TGetList();
        TEntity TGetById(int id);
    }
}
