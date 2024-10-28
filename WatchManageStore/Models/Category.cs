using System.ComponentModel.DataAnnotations;

namespace WatchManageStore.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(50)]
        public string CategoryName { get; set; }
    }
}
