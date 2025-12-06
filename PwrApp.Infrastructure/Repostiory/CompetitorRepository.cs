using Microsoft.EntityFrameworkCore;
using PwrApp.Domain.CompetitorModel;
using PwrApp.Domain.IRepository;
using PwrApp.Infrastructure.Entities;

namespace PwrApp.Infrastructure.Repostiory;

public sealed class CompetitorRepository: ICompetitorRepository
{
    private readonly DbContext _dbContext;
    public CompetitorRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> AddCompetitorAsync(Competitor competitor)
    {
        CompetitorDB competitor1 = new  CompetitorDB
        {
            Name = competitor.Name.Value,
            Age = competitor.Age.Value,
            BodyWeight = competitor.BodyWeight.Value
        };
        _dbContext.Add(competitor1);
        await _dbContext.SaveChangesAsync();
        return competitor1.Id;
    }
}
