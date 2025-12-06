namespace PwrApp.Domain.CompetitorModel;

public sealed class CompetitorBodyWeight
{
    public float Value { get; }
    public CompetitorBodyWeight(float value)
    {
        if (value <= 0)
            throw new ArgumentException("Competitor body weight must be greater than zero.", nameof(value));
        Value = value;
    }
}
