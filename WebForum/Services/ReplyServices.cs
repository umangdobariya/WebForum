using HW3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW3.Services
{
    public interface IReplyServices
    {
        List<Reply> GetReplies(int Id);
        void AddReply(Reply nt);
    }
    public class ReplyServices : IReplyServices
    {
        private readonly AppDbContext db;

        public ReplyServices(AppDbContext db)
        {
            this.db = db;
        }

        public void AddReply(Reply nt)
        {
            db.Replies.Add(nt);
            db.SaveChanges();
        }

        public List<Reply> GetReplies(int Id)
        {
            return db.Replies.Where(t => t.TopicId == Id).ToList();
        }

    }
}
