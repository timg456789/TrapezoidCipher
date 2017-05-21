using NUnit.Framework;
using TrapezoidCipher;

namespace TrapezoidCipherTests
{
    class TrapezoidCipherTests
    {
        private readonly TrapezoidCipherImplementation cipher = new TrapezoidCipherImplementation();
        private const string CRYPTOGRAM = "ODAIKAEDMEHPODVITEIPNHUETBOBROHDTFSEISNIETBEFBCBTMESHGARTORDIREREAWARRERTNSIEPVRVASEOFTEDLNA";
        private const string KEYWORD = "NOCANDYFORISSUE";
        private string encrypted;

        [OneTimeSetUp]
        public void Setup()
        {
            INumericalKey keyCreation = new NumericalKey();
            var key = keyCreation.GetKey(KEYWORD);
            encrypted = cipher.Encrypt(TrapezoidTestData.WIDTH, TrapezoidTestData.HEIGHT, TrapezoidTestData.MESSAGE, key);
        }

        [Test]
        public void First_Letter()
        {
            Assert.AreEqual(CRYPTOGRAM[0], encrypted[0]);
        }

        [Test]
        public void Second_Letter()
        {
            Assert.AreEqual(CRYPTOGRAM[1], encrypted[1]);
        }

        [Test]
        public void Third_Letter()
        {
            Assert.AreEqual(CRYPTOGRAM[2], encrypted[2]);
        }

        [Test]
        public void Fourth_Letter()
        {
            Assert.AreEqual(CRYPTOGRAM[3], encrypted[3]);
        }

        [Test]
        public void Fifth_Letter()
        {
            Assert.AreEqual(CRYPTOGRAM[4], encrypted[4]);
        }

        [Test]
        public void Sixth_Letter()
        {
            Assert.AreEqual(CRYPTOGRAM[5], encrypted[5]);
        }

        [Test]
        public void Seventh_Letter()
        {
            Assert.AreEqual(CRYPTOGRAM[6], encrypted[6]);
        }

        [Test]
        public void Eighth_Letter()
        {
            Assert.AreEqual(CRYPTOGRAM[7], encrypted[7]);
        }

        [Test]
        public void Cryptogram()
        {
            Assert.AreEqual(CRYPTOGRAM, encrypted);
        }

    }
}
