using NUnit.Framework;
using TrapezoidCipher;

namespace TrapezoidCipherTests
{
    class TrapezoidTests
    {

        [Test]
        public void Trapezoid_Is_Packaged_Correctly()
        {
            var trapezoid = new Trapezoid();
            var packed = trapezoid.Pack(TrapezoidTestData.WIDTH, TrapezoidTestData.HEIGHT, TrapezoidTestData.MESSAGE);
            
            Assert.AreEqual(TrapezoidTestData.MESSAGE[0], packed[0, 0]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[1], packed[1, 0]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[2], packed[2, 0]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[3], packed[3, 0]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[4], packed[4, 0]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[5], packed[5, 0]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[6], packed[6, 0]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[7], packed[7, 0]);
            Assert.AreEqual(0, packed[8, 0]);
            Assert.AreEqual(0, packed[9, 0]);
            Assert.AreEqual(0, packed[10, 0]);
            Assert.AreEqual(0, packed[11, 0]);
            Assert.AreEqual(0, packed[12, 0]);
            Assert.AreEqual(0, packed[13, 0]);
            Assert.AreEqual(0, packed[14, 0]);

            Assert.AreEqual(TrapezoidTestData.MESSAGE[8], packed[0, 1]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[9], packed[1, 1]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[10], packed[2, 1]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[11], packed[3, 1]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[12], packed[4, 1]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[13], packed[5, 1]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[14], packed[6, 1]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[15], packed[7, 1]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[16], packed[8, 1]);
            Assert.AreEqual(0, packed[9, 1]);
            Assert.AreEqual(0, packed[10, 1]);
            Assert.AreEqual(0, packed[11, 1]);
            Assert.AreEqual(0, packed[12, 1]);
            Assert.AreEqual(0, packed[13, 1]);
            Assert.AreEqual(0, packed[14, 1]);
            
            Assert.AreEqual(TrapezoidTestData.MESSAGE[17], packed[0, 2]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[18], packed[1, 2]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[19], packed[2, 2]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[20], packed[3, 2]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[21], packed[4, 2]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[22], packed[5, 2]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[23], packed[6, 2]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[24], packed[7, 2]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[25], packed[8, 2]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[26], packed[9, 2]);
            Assert.AreEqual(0, packed[10, 2]);
            Assert.AreEqual(0, packed[11, 2]);
            Assert.AreEqual(0, packed[12, 2]);
            Assert.AreEqual(0, packed[13, 2]);
            Assert.AreEqual(0, packed[14, 2]);
            
            Assert.AreEqual(TrapezoidTestData.MESSAGE[27], packed[0, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[28], packed[1, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[29], packed[2, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[30], packed[3, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[31], packed[4, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[32], packed[5, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[33], packed[6, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[34], packed[7, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[35], packed[8, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[36], packed[9, 3]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[37], packed[10, 3]);
            Assert.AreEqual(0, packed[11, 3]);
            Assert.AreEqual(0, packed[12, 3]);
            Assert.AreEqual(0, packed[13, 3]);
            Assert.AreEqual(0, packed[14, 3]);
            
            Assert.AreEqual(TrapezoidTestData.MESSAGE[38], packed[0, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[39], packed[1, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[40], packed[2, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[41], packed[3, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[42], packed[4, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[43], packed[5, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[44], packed[6, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[45], packed[7, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[46], packed[8, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[47], packed[9, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[48], packed[10, 4]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[49], packed[11, 4]);
            Assert.AreEqual(0, packed[12, 4]);
            Assert.AreEqual(0, packed[13, 4]);
            Assert.AreEqual(0, packed[14, 4]);
            
            Assert.AreEqual(TrapezoidTestData.MESSAGE[50], packed[0, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[51], packed[1, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[52], packed[2, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[53], packed[3, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[54], packed[4, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[55], packed[5, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[56], packed[6, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[57], packed[7, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[58], packed[8, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[59], packed[9, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[60], packed[10, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[61], packed[11, 5]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[62], packed[12, 5]);
            Assert.AreEqual(0, packed[13, 5]);
            Assert.AreEqual(0, packed[14, 5]);


            Assert.AreEqual(TrapezoidTestData.MESSAGE[63], packed[0, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[64], packed[1, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[65], packed[2, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[66], packed[3, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[67], packed[4, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[68], packed[5, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[69], packed[6, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[70], packed[7, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[71], packed[8, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[72], packed[9, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[73], packed[10, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[74], packed[11, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[75], packed[12, 6]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[76], packed[13, 6]);
            Assert.AreEqual(0, packed[14, 6]);

            Assert.AreEqual(TrapezoidTestData.MESSAGE[77], packed[0, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[78], packed[1, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[79], packed[2, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[80], packed[3, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[81], packed[4, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[82], packed[5, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[83], packed[6, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[84], packed[7, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[85], packed[8, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[86], packed[9, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[87], packed[10, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[88], packed[11, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[89], packed[12, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[90], packed[13, 7]);
            Assert.AreEqual(TrapezoidTestData.MESSAGE[91], packed[14, 7]);

            Assert.AreEqual(TrapezoidTestData.MESSAGE.Length, 92);
        }
    }
}
