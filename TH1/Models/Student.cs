using System.ComponentModel.DataAnnotations;

namespace TH_01.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [Required(ErrorMessage = "Hãy nhập họ tên")]
        [Display(Name = "Họ và tên")]
        [StringLength(100, MinimumLength = 4)]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [Display(Name = "Địa chỉ Email")]
        [RegularExpression(@"^[a-z0-9](\.?[a-z0-9]){5,}@g(oogle)?mail\.com$",ErrorMessage = "Email không đúng định dạng")]
        public string? Email { get; set; } //Email
        [StringLength(100, MinimumLength = 8,ErrorMessage = "Độ dài mật khẩu phải có ít nhất 8 kí tự")]
        [Required(ErrorMessage = "Hãy nhập mật khẩu")]
        [Display(Name = "Mật khẩu")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&*!])[A-Za-z\d@#$%^&*!]{8,}$")]
        public string? Password { get; set; }//Mật khẩu
        [Required]
        [Display(Name = "Ngành học")]
        public Branch? Branch { get; set; }//Ngành học
        [Required(ErrorMessage = "Hãy chọn giới tính")]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; }//Giới tính
        [Required]
        [Display(Name = "Hệ chính quy")]
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Hãy nhập địa chỉ")]
        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }//Địa chỉ
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Hãy nhập ngày sinh")]
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh
        [Required(ErrorMessage = "Hãy nhập điểm")]
        [Display(Name = "Điểm")]
        [RegularExpression(@"^(10(\.0{1,2})?|[0-9](\.\d{1,2})?)$",ErrorMessage = "Bắt buộc nhập kiểu số thực và miền giá trị từ 0.0 đến 10.0")]
        public float Diem { get; set; }//Điểm


        //public IFormFile Image { get; set; }    
    }
}
