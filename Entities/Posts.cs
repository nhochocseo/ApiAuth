using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class Posts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string Desscription { get; set; }
        public bool Status { get; set; }
        public string Thumbnail { get; set; }
        public string ListImage { get; set; }
        public string Url { get; set; }
        public string Tag { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastEdit { get; set; }
    }
}
