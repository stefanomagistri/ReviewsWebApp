using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Newtonsoft.Json;
using ReviewsWebApp.Models;

namespace ReviewsWebApp.Patterns
{
    public class ReviewsRepository : IRepository<ReviewModel>
    {
        private readonly IContext<JsonReviews> context;

        public ReviewsRepository(IContext<JsonReviews> context)
        {
            this.context = context;
        }

        public IEnumerable<ReviewModel> GetSubListReviews(int startIndex, int takeCount)
        { 
            var reviews = context.Reviews.Skip(startIndex).Take(takeCount);

            return reviews;
        }

        public int Count()
        { 
            return context.Reviews.Count();
        }
    }
}