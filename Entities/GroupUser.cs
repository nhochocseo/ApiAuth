using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class GroupUser
    {
        public int Id { get; set; }
        public string ShortNameGroup { get; set; }
        public int UserId { get; set; }
    }
}
