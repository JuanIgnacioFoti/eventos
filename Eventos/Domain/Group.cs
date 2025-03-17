using System.ComponentModel.DataAnnotations;
namespace Domain;

public class Group
{
	public Guid Id { get; set; }

	[Required(ErrorMessage = "El nombre es obligatorio")]
	public string Name { get; set; }
	public List<User> Members { get; set; }
	public Group()
	{
		Id = Guid.NewGuid();
	}
}