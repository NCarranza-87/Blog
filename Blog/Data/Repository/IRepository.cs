using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repository
{
    public interface IRepository
    {
        Post GetPost(int id);
        List<Post> GetAllPost(int id);
        void AddPost(Post post);
        void UpdatePost(Post id);
        void RemovePost(int id);
        

        Task<bool> SaveChangesAsync();
    }
}
