using System.Collections.Generic;

namespace DryFusion
{
    public interface IDatFileReader
    {
        IEnumerable<string> ReadFile(string path);
    }
}