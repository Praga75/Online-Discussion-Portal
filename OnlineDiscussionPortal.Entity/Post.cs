using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDiscussionPortal.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn = DateTime.Now;

        public Post(int Id,string Title,string Content,DateTime CreatedOn)
        {
            this.Id = Id;
            this.Title = Title;
            this.Content = Content;
            this.CreatedOn = CreatedOn;
        }
        public Post()
        {

        }
    }
}
