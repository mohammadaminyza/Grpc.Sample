using Grpc.Sample.Core.Domain.Courses.Entities;
using M.YZ.Basement.Infra.Data.Sql.Commands;
using Microsoft.EntityFrameworkCore;

namespace Grpc.Sample.Infra.Data.Sql.Commands.Common;

public class GRpcSampleCommandDbContext : BaseCommandDbContext
{
    #region Constructors
    public GRpcSampleCommandDbContext(DbContextOptions<GRpcSampleCommandDbContext> options) : base(options)
    {
    }

    public GRpcSampleCommandDbContext()
    {
    }
    #endregion

    #region DbSets

    public DbSet<Course> Courses { get; set; }

    #endregion

    #region overrides

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    #endregion
}