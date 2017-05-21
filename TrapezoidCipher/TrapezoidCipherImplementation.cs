using System.Collections.Generic;

namespace TrapezoidCipher
{
    public class TrapezoidCipherImplementation
    {
        public string Encrypt(int width, int height, string message, List<int> key)
        {
            var shape = new Trapezoid();
            var trapezoid = shape.Pack(width, height, message);
            string cryptogram = string.Empty;

            for (var keyIndex = 1; keyIndex <= key.Count; keyIndex++)
            {
                var currentKeyIndex = key.IndexOf(keyIndex);
                for (var row = height - 1; row > -1; row--)
                {
                    char rawLetter = trapezoid[currentKeyIndex, row];
                    if (rawLetter != default(char))
                    {
                        cryptogram += rawLetter.ToString();
                    }
                }
            }

            return cryptogram;
        }
        
    }
}
