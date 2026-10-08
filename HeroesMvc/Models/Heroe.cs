using System.ComponentModel.DataAnnotations;

namespace HeroesMvc.Models;

public class Heroe
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;
}
