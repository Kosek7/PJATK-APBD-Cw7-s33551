namespace PcManagerAPI.DTOs;

public record PcResponse(
    int Id,
    string Name,
    double Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock
);