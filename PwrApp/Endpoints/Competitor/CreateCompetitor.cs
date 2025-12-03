using FastEndpoints;

namespace PwrApp.Endpoints.Competitor;

public class CreateCompetitor : Endpoint<CompetitorRequest>
{
    public override void Configure()
    {
        Post("/competitor/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CompetitorRequest req, CancellationToken ct)
    {
        await Send.OkAsync(new { Message = $"Competitor {req.Name} created successfully!" }, cancellation: ct);
    }
}
