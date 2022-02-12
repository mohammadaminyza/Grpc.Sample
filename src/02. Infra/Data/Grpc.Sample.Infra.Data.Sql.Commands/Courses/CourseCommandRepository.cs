using Grpc.Sample.Core.Contracts.Courses.Contracts;
using Grpc.Sample.Core.Domain.Courses.Entities;
using Grpc.Sample.Infra.Data.Sql.Commands.Common;
using M.YZ.Basement.Infra.Data.Sql.Commands;

namespace Grpc.Sample.Infra.Data.Sql.Commands.Courses;

public class CourseCommandRepository : BaseCommandRepository<Course, GRpcSampleCommandDbContext>, ICourseCommandRepository
{
    public CourseCommandRepository(GRpcSampleCommandDbContext dbContext) : base(dbContext)
    {
    }
}