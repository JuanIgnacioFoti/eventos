using System.ComponentModel.DataAnnotations;
namespace Domain;

public class User
{
	public Guid Id { get; set; }

	[Required(ErrorMessage = "El nombre es obligatorio")]
	public string Name { get; set; }

/*	[Required(ErrorMessage = "El apellido es obligatorio")]
	public string LastName { get; set; }*/

	[Required(ErrorMessage = "El correo electrónico es obligatorio")]
	[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Formato de correo electrónico inválido")]
	public string Email { get; set; }

	[Required(ErrorMessage = "La contraseña es obligatoria")]
	[MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres")]
	[RegularExpression(@"^(?=.*[!@#$%^&*(),.?{}|<>]).+$", ErrorMessage = "La contraseña debe contener al menos un carácter especial")]
	public string Password { get; set; }

	public string ProfilePicture { get; set; } = string.Empty;

	public User()
	{
		Id = Guid.NewGuid();
	}
}