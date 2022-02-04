using Grpc.Sample.Core.Domain.Common.ValueObjects;
using M.YZ.Basement.Core.Domain.Entities;
using M.YZ.Basement.Core.Domain.Toolkits.ValueObjects;

namespace Grpc.Sample.Core.Domain.Courses.Entities;

#nullable disable

public class Course : AggregateRoot
{
    #region Properties

    public Title Title { get; set; }
    public Description Description { get; set; }
    public Rate Rate { get; set; }

    #endregion

    #region Ctor

    private Course()
    {
        
    }

    public Course(Title title, Description description, Rate rate)
    {
        Title = title;
        Description = description;
        Rate = rate;
    }

    #endregion

    #region Methods

    

    #endregion
}