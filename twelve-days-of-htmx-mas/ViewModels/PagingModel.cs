namespace Htmxmas.ViewModels;

public record PagingModel(int CurrentDay)
{
    public bool HasPreviousDay => CurrentDay > 1;
    public int PreviousDay => CurrentDay - 1;
    public bool HasNextDay => CurrentDay < 12;
    public int NextDay => CurrentDay + 1;
}