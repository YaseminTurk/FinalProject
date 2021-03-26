using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class = referans tip
    //IEntity = IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() = new'lenebilir bir nesne olmalı (IEntity i devre dışı bırakmak için)
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre verilmezse tüm datayı getirir.
        T Get(Expression<Func<T, bool>> filter); //filtre zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
