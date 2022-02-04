using M.YZ.Basement.Core.Contracts.ApplicationServices.Commands;

namespace Grpc.Sample.Core.Contracts.Courses.Commands.CreateCourse;

#nullable disable

public class CreateCourseCommand : ICommand
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Rate { get; set; }
}