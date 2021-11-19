using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorys
{
    public abstract class BaseRepository <M> where M: BaseModel
    {
        /*
         * 
         */
        public virtual void Create(M model)
        {
            using (var context = new RestContext())
            {
                context.Set<M>().Add(model);
                context.SaveChanges();
            }
        }
        public virtual List<M> Read()
        {
            using (var context = new RestContext())
            {
                return context.Set<M>().ToList();
            }
        }
        public virtual M Read(int id)
        {
            using (var context = new RestContext())
            {
                M model = context.Set<M>().Find(id);

                if (model == null)
                {
                    throw new Exception();
                }

                return model ;
            }
        }
        public virtual void Update(M model)
        {
            using (var context = new RestContext())
            {
                context.Entry<M>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public virtual void Delete(int id)
        {
            using (var context = new RestContext())
            {
                try
                {
                    context.Entry<M>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();

                }catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    throw new Exception();
                }
            }
        }
    }
}
