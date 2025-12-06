using PwrApp.Domain.CompetitorModel;

namespace PwrApp.Domain.IRepository;

public interface ICompetitorRepository
{
    Task<int> AddCompetitorAsync(Competitor competitor);
}
