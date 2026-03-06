using System.ComponentModel.DataAnnotations;

namespace InvestigacionFront.Models;

public class GrupoInvestigacion
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(150)]
    public string Nombre { get; set; } = string.Empty;

    [Url(ErrorMessage = "La URL no es válida")]
    public string? UrlGruplac { get; set; }

    [Required]
    public string Categoria { get; set; } = "A";

    [Required]
    public string Convocatoria { get; set; } = string.Empty;

    [Required]
    public DateTime FechaFundacion { get; set; } = DateTime.Today;

    [Required]
    public string Universidad { get; set; } = string.Empty;

    public bool Interno { get; set; }

    [Required]
    public string Ambito { get; set; } = "Nacional";
}
