using System;
using System.Linq;

using FluentMigrator.Runner;
using FluentMigrator.Runner.Initialization;

using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using ConsoleApp1.Services;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Host=localhost;Port=5433;Database=test;Username=postgres;Password=1234";
            var serviceProvider = MigrationService.CreateServices(connectionString);
            MigrationService.UpdateDatabase(serviceProvider);

        }      
    }
}