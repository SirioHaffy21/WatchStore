using AutoMapper;
using WatchManageStore.Areas.Admin.Controllers;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Controllers;
using WatchManageStore.Models;
using AccountVM = WatchManageStore.Areas.Admin.Models.AccountVM;

namespace WatchManageStore.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Watch, WatchVM>().ReverseMap();
            CreateMap<DetailWatch, DetailWatchVM>().ReverseMap();
            CreateMap<Store, StoreDetailVM>().ReverseMap();
            CreateMap<Comment, CommentVM>().ReverseMap();
            CreateMap<Store, StoreVM>().ReverseMap();
            CreateMap<Comment, CommentVM>().ReverseMap(); 
            CreateMap<Post, PostVM>().ReverseMap();
            CreateMap<Account, AccountCreateVM>().ReverseMap();
            CreateMap<Store, StoreVM>().ReverseMap();
            CreateMap<Post, PostRequest>().ReverseMap();
            CreateMap<AccountVM, Account>().ReverseMap();
            CreateMap<Watch,WatchRequest>().ReverseMap(); 
            CreateMap<DetailWatch,WatchRequest>().ReverseMap();
        }
    }
}
