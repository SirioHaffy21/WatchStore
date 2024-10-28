using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchManageStore.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [MaxLength(50)]
        public int PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public Watch Watch { get; set; }
        public string UserId { get; set; }
        [ForeignKey("Id")]
        public Account Accounts { get; set; }
        public bool Publish { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Content { get; set; }
    }
}
