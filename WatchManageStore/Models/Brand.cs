using System.ComponentModel.DataAnnotations;

namespace WatchManageStore.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; } 
        public string BrandName { get; set; } 
        public string Image { get; set; } 
    }
}
