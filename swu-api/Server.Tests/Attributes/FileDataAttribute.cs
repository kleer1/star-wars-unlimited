using System.Reflection;
using Xunit.Sdk;

namespace Server.Tests.Attributes
{
    public class FileDataAttribute : DataAttribute
    {
        private readonly string _filePath;

        public FileDataAttribute(string filePath) 
        {
       
            _filePath = filePath;
        }
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            if (testMethod == null) { throw new ArgumentNullException(nameof(testMethod)); }

            string path = Path.IsPathRooted(_filePath)
                ? _filePath
                : Path.GetRelativePath(Directory.GetCurrentDirectory(), _filePath);

            if (!File.Exists(path))
            {
                throw new ArgumentException($"Could not find file at path: {path}");
            }

            string fileData = File.ReadAllText(_filePath);

            return new List<object[]>
            {
                new object[]
                {
                    fileData
                }
            };
        }
    }
}
