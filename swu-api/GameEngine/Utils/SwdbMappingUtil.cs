using System.Collections.Concurrent;

namespace SwuApi.GameEngine.Utils
{
    internal static class SwdbMappingUtil
    {
        public static IReadOnlyDictionary<string, string> SwdbMapping = new ConcurrentDictionary<string, string>
        {

        };
    }
}
