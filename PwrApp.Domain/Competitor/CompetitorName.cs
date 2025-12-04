namespace PwrApp.Domain.Competitor;

public sealed class CompetitorName
{
    public string Value { get; }
    public CompetitorName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Competitor name cannot be empty.", nameof(value));
        if (value.Length > 100)
            throw new ArgumentException("Competitor name cannot exceed 100 characters.", nameof(value));
        Value = value;
    }
}
