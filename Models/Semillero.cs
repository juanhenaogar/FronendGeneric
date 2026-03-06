using System.ComponentModel.DataAnnotations;

namespace InvestigacionFront.Models;

public class Semillero
{
    public int Id { get; set; }

    [Required]
    [StringLength(150)]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    public DateTime FechaFundacion { get; set; } = DateTime.Today;

    [Required]
    public int GrupoInvestigacionId { get; set; }
}
