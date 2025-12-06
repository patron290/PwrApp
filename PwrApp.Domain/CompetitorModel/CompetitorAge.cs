namespace PwrApp.Domain.CompetitorModel;

public sealed class CompetitorAge
{
    public int Value { get; }
    public CompetitorAge(int value)
    {
        if (value < 0)
            throw new ArgumentException("Competitor age cannot be negative.", nameof(value));
        Value = value;
    }
}
