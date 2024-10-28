
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Repository
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        private readonly ApplicationDBContext _context;
        public PostRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<Post>();
        }
        public Post GetDetail(int postId)
        {
            //bug (dau vao ,dau ra ), loi khac nhau 
            var pt = _context.Posts.ToList();
            var posts = _context.Posts.FirstOrDefault(p =>
                  p.PostId == postId);
            return _context.Posts.FirstOrDefault(p =>
                 p.PostId == postId);
        }
        public List<Post> FindPost()
        {
            return _dbSet.Include(x => x.Accounts).Include(x => x.RateAccounts).OrderByDescending(x => x.CreateOn).Take(3).ToList();
        }
        public void DeleteById(int id)
        {
            var post = _context.Posts.Find(id);
            _context.Posts.Remove(post);
        }
    }
}
