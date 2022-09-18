using System.ComponentModel.DataAnnotations;


namespace RoutingNavigationApp.Areas.User.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
