using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAuthServer.Core.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class // will take Generic TEntity (type TEntity)
    {
        Task<TEntity> GetByIdAsync(int id); // will return Tentity

        Task<IEnumerable<TEntity>> GetAllAsync(); // tum datalari aliyorsak ve sorgulama yapmiyorsak, IQueryable yerine IEnumerable kullanabiliriz.


        //where(x=>x.id>5) // x, Func<TEntity ye karsilik geliyor. x.id>5 ise  bool>> tarafa karsilik geliyor. 
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate); // will return IQueryable, type TEntity. Func build in delegate olarak fonksiyonu isaret eder. Entitiy alacak, geriye bool donecek. 

        // product = productRepository.where(x=>x.id>5); // sorgu daha yansitilmadi cunku IQueryable
        // product.any ... // daha fonksiyon kullanilabilir. 

        //product.ToList(); // IQueryable oldugundan tum sorgular burada birlestirilir ve calistirilir. 


        Task AddAsync(TEntity entity);

        void Remove(TEntity entity); // entity framework save changes method cagirilana kadar silmiyor, state bilgisi delated olarak isaretleniyor sadece. bu sabebten herhangi baska islem yapmadigindan asenkron degil. veri eklemede bellege cok satirli veriyi yazdigindan, asenkron olmasi elzem.

        TEntity Update(TEntity entity); // sadece entity'nin memorydeki durumu degisecegi icin asenkron degil. 
    }
}
