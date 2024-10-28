using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WatchManageStore.Models
{
    public class Watch
    {
        [Key]
        public int WatchId { get; set; }
        [MaxLength(500)]
        public string WatchName { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }  
        public double Price { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime InsuranceDate { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]

        public Category Categories { get; set; }

        public int StoreId { get; set; }
        [ForeignKey("StoreId")]
        public Store Store { get; set; }  
        public DetailWatch DetailWatch { get; set; } 
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]

        public Brand Brands { get; set; }
        public IList<RateAccount> RateAccounts { get; set; }
    }
}
