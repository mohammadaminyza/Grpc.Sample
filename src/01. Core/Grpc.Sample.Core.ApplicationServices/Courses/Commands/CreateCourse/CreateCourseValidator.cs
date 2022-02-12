using FluentValidation;
using Grpc.Sample.Core.Contracts.Courses.Commands.CreateCourse;
using M.YZ.Basement.Utilities.Services.Localizations;

namespace Grpc.Sample.Core.ApplicationServices.Courses.Commands.CreateCourse;

public class CreateCourseValidator : AbstractValidator<CreateCourseCommand>
{
    public CreateCourseValidator(ITranslator translator)
    {
        RuleFor(c => c.Title)
            .NotEmpty().WithMessage("Title Not Empty");

        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Description Not Empty");

        RuleFor(c => c.Rate)
            .NotEmpty().WithMessage("Rate Not Empty");
    }
}