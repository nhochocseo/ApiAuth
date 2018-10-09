using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class Categorys
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        public string Url { get; set; }
    }
}
