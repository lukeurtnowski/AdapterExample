using AdaptersExample.DataModel;
using AdaptersExamplle.Adaptors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaptersExamplle.Adaptors.Adaptors
{
    public class MockPostAdaptor : IPost
    {
        private List<Post> _posts = new List<Post>();
        public MockPostAdaptor()
        {
            _posts.Add(new Post { Id = 1, Author = "Luke", Title = "A blog post", Body = "My first blog entry!", TimeStamp = DateTime.Now });
            _posts.Add(new Post { Id = 2, Author = "Lawrence", Title = "Some blog post", Body = "My first blog entry!", TimeStamp = DateTime.Now });
            _posts.Add(new Post { Id = 3, Author = "Alex", Title = "Another blog post", Body = "My first blog entry!", TimeStamp = DateTime.Now });
          
        }

        public Post GetPost(int id)
        {

            return _posts.FirstOrDefault(p => p.Id == id);
        }
        public List<Post> GetAll()
        {
            return _posts;
        }
    }
}