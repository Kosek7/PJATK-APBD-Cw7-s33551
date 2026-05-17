using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PcManagerAPI.Models;

[Table("Components")]
public class Component
{
    [Key]
    [Column(TypeName = "char(10)")]
    public string Code { get; set; } = string.Empty;

    [MaxLength(300)]
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int ComponentManufacturersId { get; set; }

    public int ComponentTypesId { get; set; }

    [ForeignKey(nameof(ComponentManufacturersId))]
    public ComponentManufacturer ComponentManufacturer { get; set; } = null!;

    [ForeignKey(nameof(ComponentTypesId))]
    public ComponentType ComponentType { get; set; } = null!;

    public IEnumerable<PCComponent> PCComponents { get; set; } = [];
}