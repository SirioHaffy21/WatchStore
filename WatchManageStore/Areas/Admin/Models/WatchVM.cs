using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WatchManageStore.Models;

namespace WatchManageStore.Areas.Admin.Models
{
    public class WatchVM
    {
        public int WatchId { get; set; }
        [Required]
        [Display(Name = "Tên đồng hồ")]
        public string WatchName { get; set; }

        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }

        [MaxLength(500)]
        [Display(Name = "Mô tả")]
        public string Discription { get; set; }

        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }

        [Display(Name = "Giá")]
        public double Price { get; set; }

        [Display(Name = "Ngày bắt đầu bảo hành")]
        public DateTime InsuranceDate { get; set; }

        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }

        [Display(Name = "Cửa hàng")]
        public int StoreId { get; set; }

        [Display(Name = "Hãng")]
        public int BrandId { get; set; }

        public double Rate { get; set; }

        public DetailWatchVM DetailWatch { get; set; }
        
    }

    public class WatchEditVM
    {
        public int WatchId { get; set; }

        [Required]
        [Display(Name = "Tên đồng hồ")]
        public string WatchName { get; set; }

        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }

        [MaxLength(500)]
        [Display(Name = "Mô tả")]
        public string Discription { get; set; }

        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }

        [Display(Name = "Giá")]
        public double Price { get; set; }

        [Display(Name = "Ngày bắt đầu bảo hành")]
        public DateTime InsuranceDate { get; set; }

        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }

        [Display(Name = "Cửa hàng")]
        public int StoreId { get; set; }

        [Display(Name = "Hãng")]
        public int BrandId { get; set; }

        public DetailWatchEditVM DetailWatch { get; set; }
    }
}
