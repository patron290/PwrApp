using System.ComponentModel.DataAnnotations;

namespace PwrApp.Infrastructure.Entities;

public sealed class CompetitorDB
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public float BodyWeight { get; set; }
}
