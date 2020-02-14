using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HW3.Models;
using System.IO;


namespace HW3.Services
{
    public interface IForumServices
    {
        List<Forum> GetForums();
        List<Forum> GetForum(int Id);
        void AddForum(Forum forum);
    }

    public class ForumServices : IForumServices
    {
        private readonly AppDbContext db;

        public ForumServices(AppDbContext db)
        {
            this.db = db;
        }

        public void AddForum(Forum forum)
        {
            db.Forums.Add(forum);
            db.SaveChanges();
        }

        public List<Forum> GetForum(int Id)
        {
            return db.Forums.Where(f => f.Id == Id).ToList();
        }

        public List<Forum> GetForums()
        {
              return db.Forums.ToList();
        }
    }
}
