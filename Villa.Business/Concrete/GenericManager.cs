using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Villa.Business.Abstract;

namespace Villa.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        
        public Task<int> TCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task TCreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task TDeleteAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<T> TGetByIdAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> TGetFilteredListAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> TGetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task TUpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
