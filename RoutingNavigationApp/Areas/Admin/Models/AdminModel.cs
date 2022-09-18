using System.ComponentModel.DataAnnotations;


namespace RoutingNavigationApp.Areas.Admin.Models
{
    public class AdminModel
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
       public string Password { get; set; }

       //public String ImagePath
       // {
       //     get
       //     {
       //         return "~/img/pro.jpg";
       //     }

       // }
    }
}
