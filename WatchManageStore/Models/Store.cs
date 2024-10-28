using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WatchManageStore.Models
{
    public class Store
    {
        [Key]
        public int StoreId { get; set; }
        [MaxLength(50)]
        public string StoreName { get; set; }
        public bool Status { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Address { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }  
        public string Phone { get; set; }    
        public string Image { get; set; }
        public List<Watch> Watches { get; set; }
        public IList<RateAccount> RateAccounts { get; set; }

    }
}
