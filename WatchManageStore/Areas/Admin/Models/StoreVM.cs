using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WatchManageStore.Models;

namespace WatchManageStore.Areas.Admin.Models
{
    public class StoreVM
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public bool Status { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        [MaxLength(500)]
        public List<Watch> Watches { get; set; }
        public IList<RateAccount> RateAccounts { get; set; }
        public double Rate { get; set; }
    }
}
