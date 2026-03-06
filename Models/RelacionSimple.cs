using System.ComponentModel.DataAnnotations;

namespace InvestigacionFront.Models;

public class RelacionSimple
{
    public int Id { get; set; }

    [Required]
    public string TipoRelacion { get; set; } = string.Empty;

    [Required]
    public string Origen { get; set; } = string.Empty;

    [Required]
    public string Destino { get; set; } = string.Empty;
}
