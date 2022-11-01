using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariCore
{
    public interface IBaseRepository<T> where T : class
    {
        public List<T> List();
        public T Find(int id);
        public T Find(string id);
        bool Update(T entity);
        bool Delete(T entity);
        bool Add(T entity);
        public DbSet<T> Set();
    }
}
