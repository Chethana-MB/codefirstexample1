using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirstexample1
{
    public class Post
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Body { set; get; }
        public DateTime DatePublished { set; get; }
    }
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        internal class Program
        {
            static void Main(string[] args)
            {
                BlogContext cnt = new BlogContext();
                IPost objpost;
                objpost=new PostRepository(cnt);
                //// Post Obj1 = new Post()
                // //{
                //     Id = 1,
                //     Title = "post1",
                //     DatePublished = DateTime.Now,
                //     Body = "This is post 1 body"
                // };
                // objpost.insertPost(Obj1);
                // //objpost.save();
                List<Post> posts = objpost.GetPosts();
                foreach(Post p in posts)
                {
                    Console.WriteLine("{0}-{1}-{2}-{3}",
                        p.Id,p.Title,p.Body,p.DatePublished);
                }
                //Console.WriteLine("enter the post id to be updated ");
                //int postid = Convert.ToInt32(Console.ReadLine());
                //Post postobeupdated = objpost.GetPostID(postid);
                //postobeupdated.DatePublished = DateTime.Now.AddDays(2);
                //postobeupdated.Title = "Title3 ";
                //postobeupdated.Body = "Body post of 3";

                //objpost.updatePost(postobeupdated);
                //objpost.save();

                Console.WriteLine("enter the post id to be deleted");
                int postid2=Convert.ToInt32(Console.ReadLine());

                objpost.deletePost(postid2);
                objpost.save();
            }


        }
        }
    }

