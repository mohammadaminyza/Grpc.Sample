using FluentValidation;
using Grpc.Sample.Core.Contracts.Courses.Commands.CreateCourse;
using M.YZ.Basement.Utilities.Services.Localizations;

namespace Grpc.Sample.Core.ApplicationServices.Courses.CreateCourse;

public class CreateCourseValidator : AbstractValidator<CreateCourseCommand>
{
    public CreateCourseValidator(ITranslator translator)
    {
        RuleFor(c => c.Title)
            .NotEmpty().WithMessage(translator[""]);

        RuleFor(c => c.Description)
            .NotEmpty().WithMessage(translator[""]);

        RuleFor(c => c.Rate)
            .NotEmpty().WithMessage(translator[""]);
    }
}