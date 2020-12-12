using System.Collections.Generic;

namespace nfl
{
    public interface IItemParser<T>
    {
        List<T> ParseFile(string fileName, char delimiter);
    }
}
