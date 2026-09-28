using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LdnkThDay06.Models.ViewModels
{
    public class RegisterViewModel
    {
        [DisplayName("Ten Dang Nhap")]
        [Required(ErrorMessage = "Ten dang nhap khong duoc de trong")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Ten dang nhap phai tu 3 den 20 ky tu")]
        public string Username { get; set; }

        [DisplayName("Ho Ten")]
        [Required(ErrorMessage = "Ho ten khong duoc de trong")]
        public string FullName { get; set; }

        [DisplayName("Mat Khau")]
        [Required(ErrorMessage = "Mat khau khong duoc de trong")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Go lai Mat Khau")]
        [Required(ErrorMessage = "Vui long nhap lai mat khau")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email khong duoc de trong")]
        [EmailAddress(ErrorMessage = "Email khong hop le")]
        public string Email { get; set; }

        [DisplayName("So Dien Thoai")]
        [Required(ErrorMessage = "So dien thoai khong duoc de trong")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "So dien thoai khong hop le")]
        public string PhoneNumber { get; set; }

        [DisplayName("Ngay Sinh")]
        [Required(ErrorMessage = "Ngay sinh khong duoc de trong")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
