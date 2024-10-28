using System.ComponentModel.DataAnnotations;

namespace WatchManageStore.Areas.Admin.Models
{
    public class AccountVM
    {
        public string Id { get; set; }

        public string Email { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public  string Address{ get; set; }
    }
}
