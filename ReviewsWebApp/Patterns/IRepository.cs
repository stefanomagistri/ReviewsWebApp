using System.Collections.Generic;

namespace ReviewsWebApp.Patterns
{
    public interface IRepository<TEntity> where TEntity : class
    { 
        IEnumerable<TEntity> GetSubListReviews(int startIndex, int takeCount);
        int Count();
    }
}