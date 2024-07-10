using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using test.EntityClasses;
using test.HelperClasses;
using test.FactoryClasses;
using test.DatabaseSpecific;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Host=localhost;Port=5433;Database=test;Username=postgres;Password=1234";
            RuntimeConfiguration.AddConnectionString("ConnectionString.Default", connectionString);

            var student = new StudentEntity
            {
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(2000, 1, 1),
                Email = "john.doe@example.com"
            };

            using (var adapter = new DataAccessAdapter())
            {
                adapter.SaveEntity(student, true);
            }

            Console.WriteLine("Student added successfully!");

            // Example: Retrieve and display students
            using (var adapter = new DataAccessAdapter())
            {
                var studentCollection = new EntityCollection<StudentEntity>();
                adapter.FetchEntityCollection(studentCollection, null);

                foreach (var stu in studentCollection)
                {
                    Console.WriteLine($"ID: {stu.Id}, Name: {stu.FirstName} {stu.LastName}");
                }
            }

            // Example: Update a student
            using (var adapter = new DataAccessAdapter())
            {
                var studentToUpdate = new StudentEntity(1); // Assuming the student with ID 1 exists
                if (adapter.FetchEntity(studentToUpdate))
                {
                    studentToUpdate.LastName = "Smith";
                    adapter.SaveEntity(studentToUpdate, true);
                    Console.WriteLine("Student updated successfully!");
                }
            }

            // Example: Delete a student
            using (var adapter = new DataAccessAdapter())
            {
                var studentToDelete = new StudentEntity(1); // Assuming the student with ID 1 exists
                if (adapter.FetchEntity(studentToDelete))
                {
                    adapter.DeleteEntity(studentToDelete);
                    Console.WriteLine("Student deleted successfully!");
                }
            }
        }
    }
}
