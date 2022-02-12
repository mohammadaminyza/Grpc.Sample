using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Sample.Core.Contracts.Courses.Commands.CreateCourse;
using Grpc.Sample.Core.Contracts.Courses.Queries;
using Grpc.Sample.Core.Domain.Courses.QueryModels.Outputs;
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

        public override async Task<CoursesResponse> GetCourses(GetCoursesRequest request, ServerCallContext context)
        {
            var query = new GetCourseQuery()
            {
                Title = request.Title,
                Description = request.Description,
                Rate = request.Rate
            };

            var queryResult = await _gRpcServiceController.Query<GetCourseQuery, IEnumerable<CourseDto>>(query);

            var result = new CoursesResponse();

            result.Courses.AddRange(queryResult.Select(c => new CourseResponse()
            {
                Title = c.Title,
                Description = c.Description,
                Rate = c.Rate
            }));

            return result;
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