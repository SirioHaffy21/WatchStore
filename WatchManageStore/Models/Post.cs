using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchManageStore.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [MaxLength(50)]

        public string UserId { get; set; }
        [ForeignKey("Id")]
        public Account Accounts { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public DateTime CreateOn { get; set; } 
        public DateTime ModifyDate { get; set; }
        public IList<Comment> Comments { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public IList<RateAccount> RateAccounts { get; set; }
    }
}
