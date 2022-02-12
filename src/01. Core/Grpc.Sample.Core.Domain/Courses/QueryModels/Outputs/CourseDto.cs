namespace Grpc.Sample.Core.Domain.Courses.QueryModels.Outputs;

#nullable disable

public class CourseDto
{
    public Guid BusinessId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Rate { get; set; }
}