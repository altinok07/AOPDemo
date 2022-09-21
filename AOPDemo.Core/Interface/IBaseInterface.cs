using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.Core.Interface
{
    public interface IBaseInterface<T> where T : class
    {
        void Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T Get(int Id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetActive();
    }
}
