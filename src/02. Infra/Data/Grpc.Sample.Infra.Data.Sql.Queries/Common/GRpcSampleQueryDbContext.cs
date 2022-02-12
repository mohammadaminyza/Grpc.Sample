using Grpc.Sample.Infra.Data.Sql.Queries.Common.Models;
using M.YZ.Basement.Infra.Data.Sql.Queries;
using Microsoft.EntityFrameworkCore;

namespace Grpc.Sample.Infra.Data.Sql.Queries.Common;

public class GRpcSampleQueryDbContext : BaseQueryDbContext
{
    public GRpcSampleQueryDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; }
}