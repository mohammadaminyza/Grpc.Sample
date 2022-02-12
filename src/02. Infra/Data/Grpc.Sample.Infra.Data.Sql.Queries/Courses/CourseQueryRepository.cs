using Grpc.Sample.Core.Contracts.Courses.Contracts;
using Grpc.Sample.Core.Domain.Courses.QueryModels.Inputs;
using Grpc.Sample.Core.Domain.Courses.QueryModels.Outputs;
using Grpc.Sample.Infra.Data.Sql.Queries.Common;
using M.YZ.Basement.Infra.Data.Sql.Queries;
using Microsoft.EntityFrameworkCore;

namespace Grpc.Sample.Infra.Data.Sql.Queries.Courses;

public class CourseQueryRepository : BaseQueryRepository<GRpcSampleQueryDbContext>, ICourseQueryRepository
{
    public CourseQueryRepository(GRpcSampleQueryDbContext dbContext) : base(dbContext)
    {
    }


    public async Task<IEnumerable<CourseDto>> Select(ICoursesDto coursesDto)
    {
        return await _dbContext.Courses.Select(c => new CourseDto()
        {
            Title = c.Title ?? string.Empty,
            Description = c.Description ?? string.Empty,
            Rate = c.Rate,
            BusinessId = c.BusinessId
        }).ToListAsync();
    }
}