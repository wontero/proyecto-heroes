using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HeroesWeb.Models;

[Table("SuperPoderes")]
public partial class SuperPoderes
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100)]
    public string Nombre { get; set; } = string.Empty;

    [StringLength(250)]
    [Display(Name = "Descripción")]
    public string? Descripcion { get; set; }

    [Display(Name = "Héroe")]
    public int HeroeId { get; set; }

    [ValidateNever]
    [ForeignKey(nameof(HeroeId))]
    public virtual Heroes Heroe { get; set; } = null!;
}
