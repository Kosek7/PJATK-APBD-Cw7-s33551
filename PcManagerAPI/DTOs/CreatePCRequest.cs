using System.ComponentModel.DataAnnotations;

namespace PcManagerAPI.DTOs;

public record CreatePcRequest(
    [MaxLength(50)] string Name,
    double Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock
);