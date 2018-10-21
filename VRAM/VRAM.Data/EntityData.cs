using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRAM.Data
{
    public class EntityData<T> where T : class
    {

        protected static VRAMEntities CreateContext()
        { 
        
            var context = new VRAMEntities();

            return context;
        }

        public List<T> Select()
        {
            return CreateContext().Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            var context = CreateContext();
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var context = CreateContext();
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var context = CreateContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
