namespace PwrApp.Domain.CompetitorModel;

public sealed class Competitor
{
    public CompetitorName Name { get; private set; }
    public CompetitorAge Age { get; private set; }
    public CompetitorBodyWeight BodyWeight { get; private set; }

    public Competitor(CompetitorName name, CompetitorAge age, CompetitorBodyWeight bodyWeight)
    {
        Name = name;
        Age = age;
        BodyWeight = bodyWeight;
    }
}
