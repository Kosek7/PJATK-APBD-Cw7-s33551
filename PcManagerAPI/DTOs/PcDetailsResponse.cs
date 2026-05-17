namespace PcManagerAPI.DTOs;

public record PcDetailsResponse(
    int Id,
    string Name,
    double Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock,
    IEnumerable<ComponentResponse> Components
);