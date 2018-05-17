using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Asopalav.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "The Email is required")]
        [DisplayName("Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Invalid Email")]
        public string Primary_Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*~]).\S{6,16}$", ErrorMessage = "Invalid Password. Min. 6 & Max. 16 characters.Password must contain at least one upper case letter,one lower case letter, one special character and one digit.")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        public string User_Fname { get; set; }

        [DisplayName("Middle Name")]
        public string User_Mname { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        public string User_Lname { get; set; }

        [DisplayName("Alternate Email")]
        public string Secondary_Email { get; set; }

        [Required(ErrorMessage = " Mobile no. is required")]
        [DisplayName("Mobile no.")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile")]
        public string Mobile { get; set; }

        [DisplayName("Alternate Mobile no.")]
        public string Alternate_Mobile { get; set; }

        [Required(ErrorMessage = " Gender is required")]
        [DisplayName("Gender ")]
        public string Gender { get; set; }
        //public List<System.Web.Mvc.SelectListItem> GenderList { get; set; }

        [Display(Name = "Date of birth")]
        [CustomDate(ErrorMessage = "Invalid date")]
        public Nullable<System.DateTime> User_DOB { get; set; }

        [Display(Name = "Anniversary Date")]
        [CustomDate(ErrorMessage = "Invalid date")]
        public Nullable<System.DateTime> User_Anniversary { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class CustomDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                DateTime d = Convert.ToDateTime(value);
                return d < DateTime.Now.AddDays(-1);
            }
            catch { return false; }
        }
    }
}
