using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.DAL.ORM.Context;
using TestLogin.DAL.ORM.Entity;

namespace TestLogin.BLL.Repository
{
    public class BaseRepository<B> where B:BaseEntity
    {
        private ProjectContext db;

        protected DbSet<B> bable;

        public BaseRepository()
        {
            db = new ProjectContext();
            bable = db.Set<B>();
        }

        public List<B> GetAll()
        {
            return bable.ToList();
        }

        public List<B> GetActive()
        {
            return bable.Where(a => a.Status == DAL.ORM.Enum.Status.Active).ToList();  //for list 
        }
       
        public B GetById(Guid id)  // ask ?
        {
            return bable.Find(id); 
        }

        public void Remove(Guid id)
        {
            B item = GetById(id);
            item.Status = DAL.ORM.Enum.Status.Deleted;
        }


        public void Add(B item)  // Using adding a just one thing 
        {
            item.Status = TestLogin.DAL.ORM.Enum.Status.Active;
            bable.Add(item);
            Save();//you have to add save method ;

        }

        public void Add(List<B> items)  // using adding depend on some parameters (Like an article needs an appuser and Categeory)
        {
            bable.AddRange(items);
            Save();////you have to add save method ;
        }

        public void Update(B item)
        {
            B update = GetById(item.ID);                       //update process
            DbEntityEntry entry = db.Entry(update);
            entry.CurrentValues.SetValues(item);
            Save();
        }

       public int Save()                         //save method is int ??
        {
            return db.SaveChanges();
        }


    }
}
