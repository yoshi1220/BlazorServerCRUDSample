using System.ComponentModel.DataAnnotations;

namespace BlazorServerCRUDSample.Data.ViewModels
{
    [CustomValidation(typeof(UserViewModel), "UserCheck")]
    public class UserViewModel
    {
        [Display(Name = "ユーザー番号")]
        public int UserId { get; set; }

        [Display(Name = "名前")]
        [Required(ErrorMessage = "名前は必須です")]
        public string UserName { get; set; } = "";

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Emailアドレスは必須です")]
        public string MailAddress { get; set; } = "";

        [Display(Name = "誕生日")]
        [Required(ErrorMessage = "誕生日は必須です")]
        public DateTime? BirthDay { get; set; } = DateTime.Now.AddYears(-20);


        public static ValidationResult UserCheck(UserViewModel model, ValidationContext context)
        {
            if (model == null)
            {
                throw new NullReferenceException();
            }

            return ValidationResult.Success;
        }

    }
}
