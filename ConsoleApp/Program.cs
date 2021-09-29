using System;
using Core.TestGenerator.Implementations;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = NUnitTestGenerator.CreateGenerator(builder =>
            {
                builder.MaxGenerateFiles = 10;
                builder.MaxReadFiles = 10;
                builder.MaxWriteFiles = 10;
            });
            generator.GenerateTestsAsync(@"C:\Users\Madi\RiderProjects\TestGenerator\ConsoleApp\input",
                @"C:\Users\Madi\RiderProjects\TestGenerator\ConsoleApp\output").Wait();
        }
    }
}