using System.ComponentModel.DataAnnotations;

namespace WatchManageStore.Areas.Admin.Models
{
    public class DetailWatchVM
    {
        [Display(Name = "Đường kính")]
        public int Diameter { get; set; }

        [Display(Name = "Chống nước")]
        public bool Waterproof { get; set; }

        [Display(Name = "Chất liệu mặt")]
        public string Facematerial { get; set; }

        [Display(Name = "Chất liệu dây")]
        public string WireMaterial { get; set; }

        [Display(Name = "Thời gian bảo hành")]
        public string Warranty { get; set; }
        
    }

    public class DetailWatchEditVM
    {
        public int Id { get; set; }

        [Display(Name = "Đường kính")]
        public int Diameter { get; set; }

        [Display(Name = "Chống nước")]
        public bool Waterproof { get; set; }

        [Display(Name = "Chất liệu mặt")]
        public string Facematerial { get; set; }

        [Display(Name = "Chất liệu dây")]
        public string WireMaterial { get; set; }

        [Display(Name = "Thời gian bảo hành")]
        public string Warranty { get; set; }
    }
}
