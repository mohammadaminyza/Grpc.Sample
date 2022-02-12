using Grpc.Sample.Core.Domain.Courses.QueryModels.Inputs;
using Grpc.Sample.Core.Domain.Courses.QueryModels.Outputs;
using M.YZ.Basement.Core.Contracts.ApplicationServices.Queries;

namespace Grpc.Sample.Core.Contracts.Courses.Queries;

#nullable disable

public class GetCourseQuery : IQuery<IEnumerable<CourseDto>>, ICoursesDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Rate { get; set; }
}