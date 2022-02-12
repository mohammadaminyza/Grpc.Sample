namespace Grpc.Sample.Infra.Data.Sql.Queries.Common.Models;

public class Course
{
    public long Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public int Rate { get; set; }

    public Guid BusinessId { get; set; }
}