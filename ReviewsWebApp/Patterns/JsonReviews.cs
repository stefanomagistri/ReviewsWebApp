using System.Collections.Generic;
using System.IO;
using System.Web;
using Newtonsoft.Json;
using ReviewsWebApp.Models;

namespace ReviewsWebApp.Patterns
{ 
    public class JsonReviews
    {
        public IEnumerable<ReviewModel> Reviews { get; set; }
    }
}