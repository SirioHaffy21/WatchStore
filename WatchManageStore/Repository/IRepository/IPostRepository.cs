using System.Collections.Generic;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Repository.IRepository
{
    public interface IPostRepository : IBaseRepository<Post> { 

        Post GetDetail(int postId);
        public List<Post> FindPost();
        public void DeleteById(int id);
    }

}
