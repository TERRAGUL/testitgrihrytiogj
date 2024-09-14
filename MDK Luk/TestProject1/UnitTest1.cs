namespace TestProject1;

using ConsoleApp2;

[TestClass]
public class UnitTest1
{

        [TestMethod]
        public void proval1()
        {
            Assert.AreEqual(5, Program.chekaem_pass("fifi"));
        }

        [TestMethod]
        public void proval2()
        {
            Assert.AreEqual(5, Program.chekaem_pass("fifififi"));
        }

        [TestMethod]
        public void proval3()
        {
            Assert.AreEqual(5, Program.chekaem_pass("fifIfiif"));
        }

        [TestMethod]
        public void proval4()
        {
            Assert.AreEqual(5, Program.chekaem_pass("fifIfi!f"));
        }

        [TestMethod]
        public void proval5()
        {
            Assert.AreEqual(5, Program.chekaem_pass(""));
        }

        [TestMethod]
        public void good()
        {
            Assert.AreEqual(5, Program.chekaem_pass("emayEe zdes vse est!! 2421"));
        }
}
