using Grpc.Sample.Core.Domain.Courses.QueryModels.Inputs;
using Grpc.Sample.Core.Domain.Courses.QueryModels.Outputs;
using M.YZ.Basement.Core.Contracts.Data.Queries;

namespace Grpc.Sample.Core.Contracts.Courses.Contracts;

public interface ICourseQueryRepository : IQueryRepository
{
    Task<IEnumerable<CourseDto>> Select(ICoursesDto coursesDto);
}