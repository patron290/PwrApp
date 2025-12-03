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
        // Here you would typically add logic to save the competitor to a database
        await Send.OkAsync(new { Message = $"Competitor {req.Name} created successfully!" }, cancellation: ct);
    }
}
