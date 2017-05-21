
namespace TrapezoidCipher
{
    public class Trapezoid
    {
        public char[,] Pack(int width, int height, string message)
        {
            int currentMessageIndex = 0;
            char[,] trapezoid = new char[width, height];

            for (int y = 0; y < height; y++)
            {
                int xMax = width - height + y + 1;

                for (int x = 0; x < xMax; x++)
                {
                    char letter = message[currentMessageIndex++];
                    trapezoid[x, y] = letter;
                }
            }

            return trapezoid;
        }
    }
}
