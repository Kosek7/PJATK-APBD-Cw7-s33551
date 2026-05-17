using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcManagerAPI.Models;

[Table("PCs")]
public class PC
{
    [Key]
    public int Id { get; set; }

    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    [Column(TypeName = "float")]
    public double Weight { get; set; }

    public int Warranty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    public int Stock { get; set; }

    public IEnumerable<PCComponent> PCComponents { get; set; } = [];
}