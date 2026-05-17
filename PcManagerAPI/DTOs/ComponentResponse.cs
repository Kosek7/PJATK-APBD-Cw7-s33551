namespace PcManagerAPI.DTOs;

public record ComponentResponse(
    string Code,
    string Name,
    string? Description,
    string Manufacturer,
    string Type,
    int Amount
);