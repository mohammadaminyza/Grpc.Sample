using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Sample.Core.Contracts.Courses.Commands.CreateCourse;
using M.YZ.Basement.EndPoints.Web.Controllers;

namespace Grpc.Sample.Endpoint.Courses.Services
{
    public class CourseService : Course.CourseBase
    {
        private readonly ILogger<CourseService> _logger;
        private readonly BaseGRpcServiceController _gRpcServiceController;

        public CourseService(ILogger<CourseService> logger, BaseGRpcServiceController gRpcServiceController)
        {
            _logger = logger;
            _gRpcServiceController = gRpcServiceController;
        }

        public override async Task<Empty> CreateCourse(CreateCourseRequest request, ServerCallContext context)
        {
            return await _gRpcServiceController.Create(new CreateCourseCommand()
            {
                Title = request.Title,
                Description = request.Description,
                Rate = request.Rate
            });
        }
    }
}