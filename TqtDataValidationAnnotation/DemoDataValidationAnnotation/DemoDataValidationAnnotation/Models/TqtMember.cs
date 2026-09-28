using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoDataValidationAnnotation.Models
{
    public class TqtMember
    {
        public int Id { get; set; }

        [DisplayName("Tài khoản")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Tài khoản có độ dài trong khoảng 3-20 ký tự")]
        public string TqtUserName { get; set; }

        [DisplayName("Mật khẩu")]
        [StringLength(100,MinimumLength =8,ErrorMessage ="Mật khẩu tối thiểu 8 ký tự")]
        public string TqtPassword {  get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage ="Email không được để trống")]
        [DataType(DataType.EmailAddress)]
        public string TqtEmail {  get; set; }

        [DisplayName("Điện thoại")]
        [Required(ErrorMessage ="Bạn chưa nhập điện thoại")]
        [RegularExpression(@"^0\d{9,9}",ErrorMessage ="Điện phải là 10 ký tự số, bắt đầu bằng số 0")]
        public string TqtPhone {  get; set; }
    }
}
