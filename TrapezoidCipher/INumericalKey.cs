using System.Collections.Generic;

namespace TrapezoidCipher
{
    public interface INumericalKey
    {
        List<int> GetKey(string keyword);
    }
}
