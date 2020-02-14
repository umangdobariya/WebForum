using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
namespace HW3.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime time { get; set; }
        public int ForumId { get; set; }
        public Forum forum { get; set; }
        public ICollection<Reply> reply { get; set; }
    }
}
