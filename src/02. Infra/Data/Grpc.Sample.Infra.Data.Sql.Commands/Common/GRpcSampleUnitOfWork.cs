using M.YZ.Basement.Core.Contracts.Data.Commands;
using M.YZ.Basement.Infra.Data.Sql.Commands;
using M.YZ.Basement.Utilities;

namespace Grpc.Sample.Infra.Data.Sql.Commands.Common;

public class GRpcSampleUnitOfWork : BaseEntityFrameworkUnitOfWork<GRpcSampleCommandDbContext>, IUnitOfWork
{
    public GRpcSampleUnitOfWork(GRpcSampleCommandDbContext dbContext, BasementServices basementServices) : base(dbContext, basementServices)
    {
    }
}