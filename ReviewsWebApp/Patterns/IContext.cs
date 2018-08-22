using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ReviewsWebApp.Models;

namespace ReviewsWebApp.Patterns
{
    public interface IContext<T> where T : class
    {
        IEnumerable<ReviewModel> Reviews { get; }
    }

    public class JsonFile : IContext<JsonReviews>
    {
        private readonly JsonReviews context;

        public JsonFile(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                this.context = JsonConvert.DeserializeObject<JsonReviews>(sr.ReadToEnd());
            }
        }
        public IEnumerable<ReviewModel> Reviews => context.Reviews;
    }
}