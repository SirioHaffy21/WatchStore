using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchManageStore.Models
{
    public class RateAccount
    {
        [Key]
        public int RateId { get; set; }
        public double Rate { get; set; }
        public int? StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }
        public int? WatchId { get; set; }
        [ForeignKey("WatchId")]
        public Watch Watch { get; set; }
        public int? PostId { get; set; }
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public string UserId { get; set; }
        [ForeignKey("Id")]
        public Account Accounts { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyDate { get; set; }


    }
}
