using System.ComponentModel.DataAnnotations;

namespace InvestigacionFront.Models;

public class ParticipaGrupo
{
    public int Id { get; set; }

    [Required]
    public string DocenteCedula { get; set; } = string.Empty;

    [Required]
    public int GrupoInvestigacionId { get; set; }

    [Required]
    public string Rol { get; set; } = string.Empty;

    [Required]
    public DateTime FechaInicio { get; set; } = DateTime.Today;

    public DateTime? FechaFin { get; set; }
}
