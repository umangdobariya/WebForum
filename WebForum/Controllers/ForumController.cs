using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HW3.Services;
using HW3.Models;

namespace HW3.Controllers
{ 

    public class ForumController : Controller
    {
        private readonly IForumServices forumServices;

        public ForumController(IForumServices forumServices)
        {
            this.forumServices = forumServices;
        }
       
        public IActionResult List()
        {
            var list = forumServices?.GetForums();
            return View(list);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Forum forum)
        {
            forum.Name = forum.Name;
            forumServices.AddForum(forum);
            return RedirectToAction(nameof(List));

        }
    }
}
