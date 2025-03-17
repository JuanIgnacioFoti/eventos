using System.ComponentModel.DataAnnotations;
namespace Domain;

public class Category
{
	public Guid Id { get; set; }

	[Required(ErrorMessage = "El nombre es obligatorio")]
	public string Name { get; set; }
	public Category()
	{
		Id = Guid.NewGuid();
	}
}