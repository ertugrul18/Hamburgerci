using Hamburgerci.DAL.EF.Abstract;
using Hamburgerci.Entities.Abstract;
using Hamburgerci.Entities.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.EF.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : BaseEntity, new()
    {
        protected readonly SqlDbContext dbContext;

        public RepositoryBase()
        {
            this.dbContext = new SqlDbContext();
        }



        public virtual int Add(T input)
        {
            dbContext.Set<T>().Add(input);
            return dbContext.SaveChanges();
        }

        public virtual int Delete(T input)
        {
            dbContext.Set<T>().Remove(input);
            return dbContext.SaveChanges();
        }

        public virtual T Find(string name)
        {
            return dbContext.Set<T>().Find(name);
        }

        public virtual IList<T> FindAll()
        {
            return dbContext.Set<T>().ToList();

        }

        public virtual T FindById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public virtual int Update(T input)
        {
            dbContext.Set<T>().Update(input);
            return dbContext.SaveChanges();
        }
    }
}
