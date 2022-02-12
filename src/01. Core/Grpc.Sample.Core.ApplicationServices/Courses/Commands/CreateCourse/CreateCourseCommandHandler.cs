using Grpc.Sample.Core.Contracts.Courses.Commands.CreateCourse;
using Grpc.Sample.Core.Contracts.Courses.Contracts;
using Grpc.Sample.Core.Domain.Courses.Entities;
using M.YZ.Basement.Core.ApplicationServices.Commands;
using M.YZ.Basement.Core.Contracts.ApplicationServices.Commands;
using M.YZ.Basement.Utilities;

namespace Grpc.Sample.Core.ApplicationServices.Courses.Commands.CreateCourse;

public class CreateCourseCommandHandler : CommandHandler<CreateCourseCommand>
{
    private readonly ICourseCommandRepository _courseCommandRepository;

    public CreateCourseCommandHandler(BasementServices basementServices, ICourseCommandRepository courseCommandRepository) : base(basementServices)
    {
        _courseCommandRepository = courseCommandRepository;
    }

    public override async Task<CommandResult> Handle(CreateCourseCommand request)
    {
        var entity = new Course(request.Title, request.Description, request.Rate);

        await _courseCommandRepository.InsertAsync(entity);
        await _courseCommandRepository.CommitAsync();

        return await OkAsync();
    }
}