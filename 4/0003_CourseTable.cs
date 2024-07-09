using FluentMigrator;
using System.Data;

namespace ConsoleApp1._4
{
    [Migration(3)]
    public class _0002_CourseTable : Migration
    {
        public override void Down()
        {
            Delete.Table("Course");
        }

        public override void Up()
        {
            Create.Table("Course")
                .WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Indexed()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Description").AsString().Nullable()
                .WithColumn("InstructorId").AsInt32().Nullable();
            Create.ForeignKey("FK_Course_Instructor")
                .FromTable("Course").ForeignColumn("InstructorId")
                .ToTable("Instructor").PrimaryColumn("Id").OnDelete(Rule.Cascade);
        }
    }
}
