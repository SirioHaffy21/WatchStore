using System.Collections.Generic;
using WatchManageStore.Models;

namespace WatchManageStore.Services.InterfaceServices
{
    public interface IPostService
    {
        IList<Post> GetListPost();
        Post GetById(int id);

    }
}
