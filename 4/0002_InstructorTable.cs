using FluentMigrator;

namespace ConsoleApp1._4
{
    [Migration(2)]
    public class _0002_InstructorTable : Migration
    {
        public override void Down()
        {
            Delete.Table("Instructor");
        }

        public override void Up()
        {
            Create.Table("Instructor")
                .WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Indexed()
                .WithColumn("FirstName").AsString().NotNullable()
                .WithColumn("LastName").AsString().NotNullable()
                .WithColumn("Email").AsString().NotNullable().Unique()
                .WithColumn("Phone").AsString().Nullable()
                .WithColumn("OfficeLocation").AsString().Nullable();
        }
    }
}
