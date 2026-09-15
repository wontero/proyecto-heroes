using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroesWeb.Models;

[Table("Heroes")]
public partial class Heroes
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100)]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La ciudad es obligatoria.")]
    [StringLength(100)]
    public string Ciudad { get; set; } = string.Empty;

    [StringLength(100)]
    [Display(Name = "Identidad secreta")]
    public string? IdentidadSecreta { get; set; }

    public virtual ICollection<SuperPoderes> SuperPoderes { get; set; } = new List<SuperPoderes>();
}
