using Grpc.Sample.Core.Contracts.Courses.Contracts;
using Grpc.Sample.Core.Contracts.Courses.Queries;
using Grpc.Sample.Core.Domain.Courses.QueryModels.Outputs;
using M.YZ.Basement.Core.ApplicationServices.Queries;
using M.YZ.Basement.Core.Contracts.ApplicationServices.Queries;
using M.YZ.Basement.Utilities;

namespace Grpc.Sample.Core.ApplicationServices.Courses.Queries;

public class GetCoursesQueryHandler : QueryHandler<GetCourseQuery, IEnumerable<CourseDto>>
{
    private readonly ICourseQueryRepository _courseQueryRepository;

    public GetCoursesQueryHandler(BasementServices basementApplicationContext, ICourseQueryRepository courseQueryRepository) : base(basementApplicationContext)
    {
        _courseQueryRepository = courseQueryRepository;
    }

    public override async Task<QueryResult<IEnumerable<CourseDto>>> Handle(GetCourseQuery request)
    {
        return await ResultAsync(await _courseQueryRepository.Select(request));
    }
}