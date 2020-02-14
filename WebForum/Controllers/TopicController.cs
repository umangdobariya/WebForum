using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HW3.Services;
using HW3.Models;
using System.Dynamic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HW3.Controllers
{
    public class TopicController : Controller
    {
        private readonly ITopicServices topicServices;
        private readonly IForumServices forumServices;

        public TopicController(ITopicServices topicServices, IForumServices forumServices)
        {
            this.topicServices = topicServices;
            this.forumServices = forumServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int id)
        {
            dynamic TopicMenu = new ExpandoObject();
            TopicMenu.Forums = forumServices.GetForum(id);
            TopicMenu.Topics = topicServices.GetTopics(id);
            return View(TopicMenu);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Topic topic, int id)
        {
            Topic nt = new Topic
            {
                Subject = topic.Subject,
                Content = topic.Content,
                ForumId = id,
                time = DateTime.Now
            };
            topicServices.AddTopic(nt);
            return RedirectToAction("List", new { Id = id });
        }
    }
}
