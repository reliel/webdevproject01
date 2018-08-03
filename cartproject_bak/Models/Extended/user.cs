using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConfirmPassword { get; set; }
    }

    public class UserMetadata
    {
        [Display(Name = "姓")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "需要填寫姓氏")]
        public string LastName { get; set; }

        [Display(Name = "名")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "需要填寫名稱")]
        public string FirstName { get; set; }        

        [Display(Name = "電子郵址Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "需要填寫Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name = "連絡電話")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "需要填寫連絡電話")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

        [Display(Name = "收貨地址")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "需要填寫收貨地址")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "需要填寫密碼")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "密碼至少需要六個字")]
        public string Password { get; set; }

        [Display(Name = "確認密碼")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "密碼輸入錯誤")]
        public string ConfirmPassword { get; set; }

    }
}