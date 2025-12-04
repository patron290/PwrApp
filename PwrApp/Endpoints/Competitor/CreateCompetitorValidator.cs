using FastEndpoints;
using FluentValidation;

namespace PwrApp.Endpoints.Competitor;

public class CreateCompetitorValidator: Validator<CompetitorRequest>
{
    public CreateCompetitorValidator()
    {
        RuleFor(x  => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

        RuleFor(x => x.Age)
            .InclusiveBetween(0, 120).WithMessage("Age must be between 0 and 120.");

        RuleFor(x => x.BodyWeight)
            .InclusiveBetween(0, 200).WithMessage("Body weight must be between 0 and 200.");
    }
}
