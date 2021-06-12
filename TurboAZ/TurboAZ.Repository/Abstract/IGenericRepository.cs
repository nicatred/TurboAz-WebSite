using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Repository.Abstract
{
    public interface IGenericRepository<Table> where Table:class,new()
    {
        List<Table> GetList();
        Table GetById(int id);
        void Update(Table entity);
        void Save(Table entity);
        void Delete(Table entity);

    }
}
