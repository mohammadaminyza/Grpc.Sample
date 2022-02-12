using Grpc.Core;
using Grpc.Net.Client;
using Grpc.Sample.Endpoint;

async Task GetCourses()
{
    await InvokeCourseGRpc(async (client) =>
    {
        var result = await client.GetCoursesAsync(new GetCoursesRequest());

        foreach (var course in result.Courses)
        {
            Console.WriteLine(
                $"Course Title {course.Title}, Course Description {course.Description} With Rate {course.Rate}");


            Console.WriteLine("________________________________________________________________________________________________________");


        }
    });
}

async Task CreateCourse()
{
    await InvokeCourseGRpc(async (client) =>
    {
        var result = await client.CreateCourseAsync(new CreateCourseRequest()
        {
            Title = "Best Legends Of Asp.net Core",
            Description = "I'm Legend",
            Rate = 5,
        });
    });
}

Task InvokeCourseGRpc(Action<Course.CourseClient> invokeAction)
{
    var channel = GrpcChannel.ForAddress("https://localhost:7169");
    var client = new Course.CourseClient(channel);

    try
    {
        invokeAction(client);
    }
    catch (RpcException e)
    {
        Console.WriteLine($"Some Thing Is Wrong : {e}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Sorry There Are Some Problems: {e.Message}");
    }

    return Task.Delay(1000);
}

await CreateCourse();
await GetCourses();


Console.ReadKey();