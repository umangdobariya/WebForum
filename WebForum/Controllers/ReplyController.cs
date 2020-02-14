using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using HW3.Models;
using HW3.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HW3.Controllers
{
    public class ReplyController : Controller
    {
        private readonly ITopicServices topicServices;
        private readonly IReplyServices replyServices;

        public ReplyController(ITopicServices topicServices, IReplyServices replyServices)
        {
            this.topicServices = topicServices;
            this.replyServices = replyServices;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int id)
        {
            dynamic TopicMenu = new ExpandoObject();
            TopicMenu.Topics = topicServices.GetTopic(id);
            TopicMenu.Replies = replyServices.GetReplies(id);

            return View(TopicMenu);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Reply reply, int id)
        {
            Reply nt = new Reply
            {
                Rep = reply.Rep,
                TopicId = id,
                time = DateTime.Now
            };
            replyServices.AddReply(nt);
            return RedirectToAction("List", new { Id = id });
        }

    }

}
