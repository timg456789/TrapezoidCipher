using System.Collections.Generic;
using NUnit.Framework;
using TrapezoidCipher;

namespace TrapezoidCipherTests
{
    class NumericalKeyTests
    {
        [Test]
        public void How_Does_A_Numerical_Key_Work()
        {
            const string KEYWORD = "lrqazxvrostvnobc";
            List<int> expected = new List<int> { 4,9,8,1,16,15,13,10,6,11,12,14,5,7,2,3 };
            var numericalKey = new NumericalKey();

            var key = numericalKey.GetKey(KEYWORD);
            Inspect(expected, key, KEYWORD);
        }

        [Test]
        public void Example_From_Book()
        {
            const string KEYWORD = "nocandyforissue";
            List<int> expected = new List<int> {7, 9, 2, 1, 8, 3, 15, 5, 10, 11, 6, 12, 13, 14, 4};
            var numericalKey = new NumericalKey();
            var key = numericalKey.GetKey(KEYWORD);
            Inspect(expected, key, KEYWORD);
        }

        [Test]
        public void Example_From_Book_Upper_Case()
        {
            const string KEYWORD = "NOCANDYFORISSUE";
            List<int> expected = new List<int> { 7, 9, 2, 1, 8, 3, 15, 5, 10, 11, 6, 12, 13, 14, 4 };
            var numericalKey = new NumericalKey();
            var key = numericalKey.GetKey(KEYWORD);
            Inspect(expected, key, KEYWORD);
        }
        
        [Test]
        public void Example_From_Book_Mixed_Case()
        {
            const string KEYWORD = "NOcANDyFORiSSuE";
            List<int> expected = new List<int> { 7, 9, 2, 1, 8, 3, 15, 5, 10, 11, 6, 12, 13, 14, 4 };
            var numericalKey = new NumericalKey();
            var key = numericalKey.GetKey(KEYWORD);
            Inspect(expected, key, KEYWORD);
        }

        private void Inspect(List<int> expected, List<int> actual, string keyword)
        {
            Assert.AreEqual(keyword.Length, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
