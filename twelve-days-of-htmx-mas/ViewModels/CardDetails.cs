namespace Htmxmas.ViewModels;

public record CardDetails(
    int Number,
    string Title,
    string Description,
    string ImageUrl,
    string Page = "Index"
);