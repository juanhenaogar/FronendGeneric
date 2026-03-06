using System.ComponentModel.DataAnnotations;

namespace InvestigacionFront.Models;

public class ParticipaSemillero
{
    public int Id { get; set; }

    [Required]
    public string Docente { get; set; } = string.Empty;

    [Required]
    public int SemilleroId { get; set; }

    [Required]
    public string Rol { get; set; } = string.Empty;

    [Required]
    public DateTime FechaInicio { get; set; } = DateTime.Today;

    public DateTime? FechaFin { get; set; }
}
