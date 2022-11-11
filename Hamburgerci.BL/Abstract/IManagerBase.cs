using Hamburgerci.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.BL.Abstract
{
    public interface IManagerBase<T> where T : BaseEntity
    {
        T FindById(int id);
        T Find(string name);

        IList<T> FindAll();

        int Add(T input);
        int Delete(T input);
        int Update(T input);
    }
}
