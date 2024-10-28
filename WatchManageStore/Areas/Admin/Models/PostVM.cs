using System;

namespace WatchManageStore.Areas.Admin.Models
{
    public class PostVM
    {
        public int PostId { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public double Rate { get; set; }
    }
}
