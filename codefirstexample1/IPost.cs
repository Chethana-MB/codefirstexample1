using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstexample1
{
    internal interface IPost
    {
        List<Post> GetPosts();

        Post GetPostID(int id);
        void insertPost(Post post);
        void updatePost(Post post);
        void deletePost(int id);
        void save();

    }
}
