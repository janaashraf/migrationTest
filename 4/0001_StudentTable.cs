using FluentMigrator;

namespace ConsoleApp1._4
{
    [Migration(1)]
    public class _0001_StudentTable : Migration
    {
        public override void Down()
        {
            Delete.Table("Student");
        }

        public override void Up()
        {
            Create.Table("Student")
                .WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Indexed()
                .WithColumn("FirstName").AsString().NotNullable()
                .WithColumn("LastName").AsString().NotNullable()
                .WithColumn("DateOfBirth").AsDate().NotNullable()
                .WithColumn("Email").AsString().NotNullable().Unique()
                .WithColumn("Phone").AsString().Nullable();
        }
    }
}
