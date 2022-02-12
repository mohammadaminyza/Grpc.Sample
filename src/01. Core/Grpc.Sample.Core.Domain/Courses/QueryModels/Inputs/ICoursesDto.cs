namespace Grpc.Sample.Core.Domain.Courses.QueryModels.Inputs;

public interface ICoursesDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Rate { get; set; }
}