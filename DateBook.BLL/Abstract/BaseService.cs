using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBook.BLL.Abstract
{
   public interface BaseService<T>
    {
        void Add(T entity);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Delete(int id);
    }
}
