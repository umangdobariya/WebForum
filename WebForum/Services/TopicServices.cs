using HW3.Models;
//using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace HW3.Services
{
    public interface ITopicServices
    {
        List<Topic> GetTopic(int Id);
        List<Topic> GetTopics(int Id);
        void AddTopic(Topic nt);
    }

    public class TopicServices : ITopicServices
    {
        private readonly AppDbContext db;

        public TopicServices(AppDbContext db)
        {
            this.db = db;
        }

        public List<Topic> GetTopic(int Id)
        {
            return db.Topics.Where(t => t.Id == Id).ToList();
        }

        public void AddTopic(Topic nt)
        {
            db.Topics.Add(nt);
            db.SaveChanges();
        }

        public List<Topic> GetTopics(int Id)
        {
            return db.Topics.Where(t => t.ForumId == Id).ToList();
        }

    }
}
