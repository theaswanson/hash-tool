﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace hashtool.Tests
{
    [TestClass]
    public class FileHasherTests
    {
        private FileHasher fileHasher;
        private string filePath = "C:/Windows/Temp/crisp-hash-tool-test.txt";
        private string hash;

        [TestInitialize]
        public void Setup()
        {
            fileHasher = new FileHasher();
            File.WriteAllText(filePath, "test");
            fileHasher.SetFilePath(filePath);
        }

        [TestMethod]
        public void Base64()
        {
            hash = fileHasher.GetBase64();
            Assert.AreEqual("dGVzdA==", hash);
        }

        [TestMethod]
        public void MD4()
        {
            hash = fileHasher.GetMD4();
            Assert.AreEqual("db346d691d7acc4dc2625db19f9e3f52", hash);
        }

        [TestMethod]
        public void MD5()
        {
            hash = fileHasher.GetMD5();
            Assert.AreEqual("098f6bcd4621d373cade4e832627b4f6", hash);
        }

        [TestMethod]
        public void SHA1()
        {
            hash = fileHasher.GetSHA1();
            Assert.AreEqual("a94a8fe5ccb19ba61c4c0873d391e987982fbbd3", hash);
        }

        [TestMethod]
        public void SHA256()
        {
            hash = fileHasher.GetSHA256();
            Assert.AreEqual("9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08", hash);
        }

        [TestMethod]
        public void SHA512()
        {
            hash = fileHasher.GetSHA512();
            Assert.AreEqual("ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff", hash);
        }

        [TestMethod]
        public void Whirlpool()
        {
            hash = fileHasher.GetWhirlpool();
            Assert.AreEqual("b913d5bbb8e461c2c5961cbe0edcdadfd29f068225ceb37da6defcf89849368f8c6c2eb6a4c4ac75775d032a0ecfdfe8550573062b653fe92fc7b8fb3b7be8d6", hash);
        }

        [TestMethod]
        public void ROT13()
        {
            hash = fileHasher.GetROT13();
            Assert.AreEqual("grfg", hash);
        }
    }
}
