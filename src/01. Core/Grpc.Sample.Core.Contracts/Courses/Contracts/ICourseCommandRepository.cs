using Grpc.Sample.Core.Domain.Courses.Entities;
using M.YZ.Basement.Core.Contracts.Data.Commands;

namespace Grpc.Sample.Core.Contracts.Courses.Contracts;

public interface ICourseCommandRepository : ICommandRepository<Course>
{
}