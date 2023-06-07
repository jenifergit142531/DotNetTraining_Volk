using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoreMvc2.Models
{
    public class JobForm
    {
        [Required(ErrorMessage ="User Name is required")]
        [Display(Name ="Applicant Name")]
        public string UserName { get; set; }

        [Range(5,10,ErrorMessage ="Required 5 - 10 years of experience")]
        [Display(Name = "Applicant Experience")]
        public int Experience { get; set; }

        [EmailAddress(ErrorMessage ="Enter a valid email address")]
        [Display(Name ="Applicant Email")]
        public string Email { get; set; }

    }
}
