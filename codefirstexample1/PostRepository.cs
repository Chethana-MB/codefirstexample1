using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstexample1
{
    internal class PostRepository : IPost
    {
        private BlogContext context;
        public PostRepository(BlogContext cnt)
        {
            this.context = cnt;
        }
        public void deletePost(int id)
        {
            Post posttodelete = context.Posts.Find(id);
            context.Posts.Remove(posttodelete);
        }

        public Post GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public Post GetPostID(int id)
        {
            return context.Posts.Find(id);
        }

        public List<Post> GetPosts()
        {
            return context.Posts.ToList();
        }

        public void insertPost(Post post)
        {
            context.Posts.Add(post);
        }

        public void save()
        {
            context.SaveChanges();
        }

        public void updatePost(Post post)
        {
            context.Entry(post).State = EntityState.Modified;
        }
    }
}
