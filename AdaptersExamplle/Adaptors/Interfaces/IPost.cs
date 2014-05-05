using AdaptersExample.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersExamplle.Adaptors.Interfaces
{
    public interface IPost
    {
        Post GetPost(int id);
        List<Post> GetAll();
    }
}
