using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineDiscussionPortal.Entity;
using OnlineDiscussionPortal.Repository;

namespace OnlineDiscussionPortal.Controllers
{
    public class UserController : Controller
    {
        PostRepository postRepository;

        public UserController()
        {
            postRepository = new PostRepository();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Post post)
        {
            postRepository.AddPost(post);
            return RedirectToAction("Display");
        }

        public ActionResult Display()
        {
            IEnumerable<Post> posts = postRepository.GetPosts();
            return View(posts);
        }
       
        
    }
}