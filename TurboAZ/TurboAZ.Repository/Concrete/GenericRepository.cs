using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.Repository.Concrete
{
   public class GenericRepository<Table> where Table:class,new()
    {
        
        public List<Table> GetList()
        {
            using(EfCoreDbContext DbContext =new EfCoreDbContext())
            {
                var result = DbContext.Set<Table>().ToList();
                return result;
            }
        }

        public Table GetById(int Id)
        {
            using (EfCoreDbContext DbContext = new EfCoreDbContext())
            {
                var result = DbContext.Set<Table>().Find(Id);
                return result;
            }
        }
        public void Update(Table entity)
        {
            using (EfCoreDbContext DbContext = new EfCoreDbContext())
            {
                var result = DbContext.Set<Table>().Update(entity);
                DbContext.SaveChanges();
            }
        }
        public void Delete(Table entity)
        {
            using (EfCoreDbContext DbContext = new EfCoreDbContext())
            {
                var result = DbContext.Set<Table>().Remove(entity);
                DbContext.SaveChanges();
            }
        }
        public void Save(Table entity)
        {
            using (EfCoreDbContext DbContext = new EfCoreDbContext())
            {
                var result = DbContext.Set<Table>().Add(entity);
                DbContext.SaveChanges();
            }
        }
        
    }
}
