using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen adınızı girin!")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen Soyadınızı girin!")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı girin!")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen Mail adresinizi girin!")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi girin!")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen adınızı girin!")]
		[Compare("Password", ErrorMessage = "Şifreniz uyumlu değil!")]
		public string ConfirmPassword { get; set; }

	}
}
