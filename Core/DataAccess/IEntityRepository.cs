
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess // Core katmanı diğer katmanları referans almaz
{   //Generic constraint 
    // where T:class ifadesi class:referans tip
    // T yada IEntity yada IEntity implemente eden bir nesne olabilir.
    // new(): new'lenebilir olmalı (interfaceler newlenemediği için IEntity konulamaz)
    public interface IEntityRepository<T> where T:class,IEntity,new ()// Generic
    {                       
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity); // interface methodları default publictir.
        void Update(T entity);
        void Delete(T entity);

        
    }
}
