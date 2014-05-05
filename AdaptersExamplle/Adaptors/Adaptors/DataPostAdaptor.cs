using AdaptersExample.Data;
using AdaptersExample.DataModel;
using AdaptersExamplle.Adaptors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaptersExamplle.Adaptors.Adaptors
{
    public class DataPostAdaptor : IPost
    {
        public Post GetPost(int id)
        {
            ApplicationDbContext ctx = new ApplicationDbContext();
            return ctx.Posts.Find(id);
        }
        public List<Post> GetAll()
        {
            ApplicationDbContext ctx = new ApplicationDbContext();
            return ctx.Posts.ToList();
        }
    }
}