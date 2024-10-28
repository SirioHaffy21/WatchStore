using System;

namespace WatchManageStore.Areas.Admin.Models
{
    public class CommentVM
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool Publish { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Content { get; set; }  
        public int Rate { get; set; }
    }
}
