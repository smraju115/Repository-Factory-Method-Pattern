using RepositoryFactoryAndMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryAndMethodPattern.Repositories
{
    public class GenericRepoImpl<T> : IGenericRepo<T> where T : IEntityBase, new()
    {
       
        private List<T> laptoplist = new List<T>();
        public IEnumerable<T> Get()
        {
            return laptoplist;
        }

        public T Get(int id)
        {
            var obj = laptoplist.Where(x=> x.Id == id).FirstOrDefault();
            return obj;
        }

        public void Insert(T entity)
        {
            laptoplist.Add(entity);
        }

        public void InsertRange(IEnumerable<T> entities)
        {
            laptoplist.AddRange(entities);
        }

        public void Update(T entity)
        {
            int i = laptoplist.FindIndex(l=>l.Id == entity.Id);
            laptoplist.RemoveAt(i);
            laptoplist.Insert(i, entity);
        }
        public void Delete(int id)
        {
            var laptop = laptoplist.FirstOrDefault(x=>x.Id == id);
            if (laptop != null)
                laptoplist.Remove(laptop);
        }
    }
}
