using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Grpc.Sample.Infra.Data.Sql.Commands.Common;

class GRpcSampleCommandDbContextFactory : IDesignTimeDbContextFactory<GRpcSampleCommandDbContext>
{
    public GRpcSampleCommandDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<GRpcSampleCommandDbContext>();
        optionsBuilder.UseSqlServer("server=.; Database=GrpcDb; User Id=sa; Password=123456; MultipleActiveResultSets=true");

        return new GRpcSampleCommandDbContext(optionsBuilder.Options);
    }
}