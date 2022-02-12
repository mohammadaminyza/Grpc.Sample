using Grpc.Sample.Core.Domain.Common.ValueObjects;
using Grpc.Sample.Core.Domain.Courses.Entities;
using M.YZ.Basement.Core.Domain.Toolkits.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grpc.Sample.Infra.Data.Sql.Commands.Courses.Configs;

public class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.Property(c => c.Title)
            .HasConversion(c => c.Value, c => Title.FromString(c));

        builder.Property(c => c.Description)
            .HasConversion(c => c.Value, c => Description.FromString(c));

        builder.Property(c => c.Rate)
            .HasConversion(c => c.Value, c => Rate.FromInt(c));
    }
}