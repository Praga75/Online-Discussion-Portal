using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineDiscussionPortal.Entity;

namespace OnlineDiscussionPortal.Repository
{
    public class PostRepository
    {
        public static List<Post> postList = new List<Post>();

        static PostRepository()
        {
            postList.Add(new Post(12, "ASP.NET", "What is Asp.Net?", DateTime.Now));
        }
        public IEnumerable<Post> GetPosts()
        {
            return postList;
        }
        public void AddPost(Post post)
        {
            postList.Add(post);
        }

    }
}
