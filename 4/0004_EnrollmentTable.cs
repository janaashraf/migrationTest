using FluentMigrator;

namespace ConsoleApp1._4
{
    [Migration(4)]
    public class _0003_EnrollmentTable : Migration
    {
        public override void Down()
        {
            Delete.Table("Enrollment");
        }

        public override void Up()
        {
            Create.Table("Enrollment")
                .WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Indexed()
                .WithColumn("StudentId").AsInt32().NotNullable()
                .WithColumn("CourseId").AsInt32().NotNullable()
                .WithColumn("EnrollmentDate").AsDateTime().NotNullable();

            Create.ForeignKey("FK_Enrollment_Student")
                .FromTable("Enrollment").ForeignColumn("StudentId")
                .ToTable("Student").PrimaryColumn("Id");

            Create.ForeignKey("FK_Enrollment_Course")
                .FromTable("Enrollment").ForeignColumn("CourseId")
                .ToTable("Course").PrimaryColumn("Id");
        }
    }
}
