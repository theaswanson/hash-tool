using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace crisp_hash_tool.Tests
{
    [TestClass]
    public class TextHasherTests
    {
        private TextHasher textHasher;

        [TestInitialize]
        public void Setup()
        {
            textHasher = new TextHasher();
        }

        [TestMethod]
        public void SetText()
        {
            textHasher.textToHash = "test";
            Assert.AreEqual("test", textHasher.textToHash);
        }

        [TestMethod]
        public void MD4()
        {
            textHasher.textToHash = "test";
            Assert.AreEqual("db346d691d7acc4dc2625db19f9e3f52", textHasher.GetMD4());
        }

        [TestMethod]
        public void MD5()
        {
            textHasher.textToHash = "test";
            Assert.AreEqual("098f6bcd4621d373cade4e832627b4f6", textHasher.GetMD5());
        }

        [TestMethod]
        public void SHA1()
        {
            textHasher.textToHash = "test";
            Assert.AreEqual("a94a8fe5ccb19ba61c4c0873d391e987982fbbd3", textHasher.GetSHA1());
        }

        [TestMethod]
        public void SHA256()
        {
            textHasher.textToHash = "test";
            Assert.AreEqual("9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08", textHasher.GetSHA256());
        }

        [TestMethod]
        public void SHA512()
        {
            textHasher.textToHash = "test";
            Assert.AreEqual("ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff", textHasher.GetSHA512());
        }

        [TestMethod]
        public void Whirlpool()
        {
            textHasher.textToHash = "test";
            Assert.AreEqual("b913d5bbb8e461c2c5961cbe0edcdadfd29f068225ceb37da6defcf89849368f8c6c2eb6a4c4ac75775d032a0ecfdfe8550573062b653fe92fc7b8fb3b7be8d6", textHasher.GetWhirlpool());
        }

        [TestMethod]
        public void Base64()
        {
            textHasher.textToHash = "test";
            Assert.AreEqual("dGVzdA==", textHasher.GetBase64());
        }

        [TestMethod]
        public void ROT13()
        {
            textHasher.textToHash = "test";
            Assert.AreEqual("grfg", textHasher.GetROT13());
        }
    }
}
