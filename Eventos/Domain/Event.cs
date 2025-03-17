using System.ComponentModel.DataAnnotations;
using System.Security;
using Domain.Enums;

namespace Domain;

public class Event
{
	public Guid Id { get; set; }

	[Required(ErrorMessage = "El título es obligatorio")]
	public string Title { get; set; }

	[Required(ErrorMessage = "La categoría es obligatoria")]
	public Category Category { get; set; }

	[Required(ErrorMessage = "El grupo es obligatorio")]
	public Group Group { get; set; }

	[Required(ErrorMessage = "La descripción es obligatoria")]
	public string Description { get; set; }

	[Required(ErrorMessage = "La fecha es obligatoria")]
	public DateTime Fecha { get; set; }

	[Required(ErrorMessage = "El estado es obligatorio")]
	public bool Estado { get; set; }

	[Required(ErrorMessage = "El permiso es obligatorio")]
	public PermissionType Permission { get; set; }

	[Required(ErrorMessage = "Es necesario especificar si requiere pago")]
	public bool NeedsPayment { get; set; }

	[Range(0, double.MaxValue, ErrorMessage = "El precio no puede ser negativo")]
	public double Price { get; set; }

	[Required(ErrorMessage = "Debe especificar si incluye juegos")]
	public bool Games { get; set; }

	[Required(ErrorMessage = "La ubicación es obligatoria")]
	public string Ubication { get; set; }

	public Event()
	{
		Id = Guid.NewGuid();
	}
}