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