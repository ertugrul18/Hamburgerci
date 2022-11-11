using Hamburgerci.Entities.Abstract;
using Hamburgerci.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.EF.Abstract
{
    public interface IRepositoryBase<T> where T : BaseEntity, new()
    {
        T FindById(int id);
        T Find(string name);

        IList<T> FindAll();

        int Add(T input);
        int Delete(T input);
        int Update(T input);
    }
}
