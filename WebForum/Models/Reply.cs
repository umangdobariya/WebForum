using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW3.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string Rep  { get; set; }
        public int TopicId { get; set; }
        public Topic topic { get; set; }
        public DateTime time { get; set; }

    }
}
