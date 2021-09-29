using System;
using Core.TestGenerator.Constants;
using Core.TestGenerator.Implementations;
using Core.TestGenerator.Interfaces;

namespace Core.TestGenerator.Builders
{
    public class NUnitTestGeneratorBuilder : ITestGeneratorBuilder
    {
        private int maxReadFiles = TestGeneratorBuilderConstants.DefaultMaxReadFiles;

        private int maxGenerateFiles = TestGeneratorBuilderConstants.DefaultMaxGenerateFiles;

        private int maxWriteFiles = TestGeneratorBuilderConstants.DefaultMaxWriteFiles;

        public int MaxReadFiles
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxReadFiles),
                        "Maximum number of files to read cannot be less than one.");
                }

                maxReadFiles = value;
            }
        }
        
        public int MaxGenerateFiles
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxGenerateFiles),
                        "Maximum number of files to generate cannot be less than one.");
                }

                maxGenerateFiles = value;
            }
        }
        
        public int MaxWriteFiles
        {
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxWriteFiles),
                        "Maximum number of files to write cannot be less than one.");
                }

                maxWriteFiles = value;
            }
        }

        public ITestGenerator Build()
        {
            return new NUnitTestGenerator(maxReadFiles, maxGenerateFiles, maxWriteFiles);
        }
    }
}