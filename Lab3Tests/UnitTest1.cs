using Microsoft.VisualStudio.TestTools.UnitTesting;
using IIG.PasswordHashingUtils;

namespace Lab3Tests
{
    [TestClass]
    public class Lab3Test
    {
        [TestMethod]
        public void EmptyArgInitTest()
        {
            string tmp = PasswordHasher.GetHash("ThisIsTest");
            PasswordHasher.Init(null, 0);
            Assert.AreEqual(tmp, PasswordHasher.GetHash("ThisIsTest"));
        }
        [TestMethod]
        public void FirstArgInitTest()
        {
            string tmp = PasswordHasher.GetHash("ThisIsTest");
            PasswordHasher.Init("test", 0);
            Assert.AreNotEqual(tmp, PasswordHasher.GetHash("ThisIsTest"));
        }
        [TestMethod]
        public void SecondArgInitTest()
        {
            string tmp = PasswordHasher.GetHash("ThisIsTest");
            PasswordHasher.Init(null, 64);
            Assert.AreNotEqual(tmp, PasswordHasher.GetHash("ThisIsTest"));
        }
        [TestMethod]
        public void TwoArgsInitTest()
        {
            string tmp = PasswordHasher.GetHash("ThisIsTest");
            PasswordHasher.Init("test", 64);
            Assert.AreNotEqual(tmp, PasswordHasher.GetHash("ThisIsTest"));
        }
        [TestMethod]
        public void EmptyArgGetHashTest()
        {
            Assert.IsNotNull(PasswordHasher.GetHash(""));
        }
        [TestMethod]
        public void SamePasswordGetHashWithOneArgTest()
        {
            Assert.AreEqual(PasswordHasher.GetHash("ThisIsTest"), PasswordHasher.GetHash("ThisIsTest"));
        }
        [TestMethod]
        public void VariousPasswordGetHashWithOneArgTest()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("ThisisTest"), PasswordHasher.GetHash("ThisIsTest"));
        }
        [TestMethod]
        public void VariousQuantityArgsTest1()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("ThisIsTest"), PasswordHasher.GetHash("ThisisTest", "put your soul(or salt) here"));
        }
        [TestMethod]
        public void VariousQuantityArgsTest2()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("ThisIsTest"), PasswordHasher.GetHash("ThisisTest", "put your soul(or salt) here", 65521));
        }
        [TestMethod]
        public void SamePasswordGetHashWithSameSecondArgsTest()
        {
            Assert.AreEqual(PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSoul"), PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSoul"));
        }
        [TestMethod]
        public void SamePasswordGetHashWithVariousSecondArgsTest()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSoul"), PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSalt"));
        }
        [TestMethod]
        public void SamePasswordGetHashWithSameThirdArgsTest()
        {
            Assert.AreEqual(PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSoul", 64), PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSoul", 64));
        }
        [TestMethod]
        public void SamePasswordGetHashWithVariousThirdArgsTest()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSoul", 64), PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSoul", 128));
        }
        [TestMethod]
        public void SamePasswordGetHashWithZeroThirdArgTest()
        {
            Assert.AreEqual(PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSoul", 64), PasswordHasher.GetHash("ThisIsTest", "GiveMeYourSoul", 0));
        }
        [TestMethod]
        public void SamePasswordGetHashWithOneArgTest2()
        {
            Assert.AreEqual(PasswordHasher.GetHash("康熙字典體"), PasswordHasher.GetHash("康熙字典體"));
        }
        [TestMethod]
        public void VariousPasswordGetHashWithOneArgTest2()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("康熙字典體"), PasswordHasher.GetHash("康熙字典体"));
        }
        [TestMethod]
        public void VariousQuantityArgsTest3()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("康熙字典體"), PasswordHasher.GetHash("康熙字典体", "put your soul(or salt) here"));
        }
        [TestMethod]
        public void VariousQuantityArgsTest4()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("康熙字典體"), PasswordHasher.GetHash("康熙字典体", "put your soul(or salt) here", 65521));
        }
        [TestMethod]
        public void SamePasswordGetHashWithSameSecondArgsTest2()
        {
            Assert.AreEqual(PasswordHasher.GetHash("康熙字典体", "GiveMeYourSoul"), PasswordHasher.GetHash("康熙字典体", "GiveMeYourSoul"));
        }
        [TestMethod]
        public void SamePasswordGetHashWithVariousSecondArgsTest2()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("康熙字典体", "GiveMeYourSoul"), PasswordHasher.GetHash("康熙字典体", "GiveMeYourSalt"));
        }
        [TestMethod]
        public void SamePasswordGetHashWithSameThirdArgsTest2()
        {
            Assert.AreEqual(PasswordHasher.GetHash("康熙字典体", "GiveMeYourSoul", 64), PasswordHasher.GetHash("康熙字典体", "GiveMeYourSoul", 64));
        }
        [TestMethod]
        public void SamePasswordGetHashWithVariousThirdArgsTest2()
        {
            Assert.AreNotEqual(PasswordHasher.GetHash("康熙字典體", "GiveMeYourSoul", 64), PasswordHasher.GetHash("康熙字典體", "GiveMeYourSoul", 256));
        }
        [TestMethod]
        public void SamePasswordGetHashWithZeroThirdArgTest2()
        {
            Assert.AreEqual(PasswordHasher.GetHash("康熙字典體", "GiveMeYourSoul", 64), PasswordHasher.GetHash("康熙字典體", "GiveMeYourSoul", 0));
        }
        /*
        [TestMethod]
        public void SpecialArgInitTest()
        {
            string tmp = PasswordHasher.GetHash("ThisIsTest");
            PasswordHasher.Init("康熙字典体", 0);
            Assert.AreNotEqual(tmp, PasswordHasher.GetHash("ThisIsTest"));
        }*/
    }
}
