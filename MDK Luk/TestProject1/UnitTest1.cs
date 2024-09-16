namespace TestProject1;

using ConsoleApp2;

[TestClass]
public class UnitTest1
{

        [TestMethod]
        public void chekaem_pass_fifi_result1()
        {
            Assert.AreEqual(5, Program.chekaem_pass("fifi"));
        }

        [TestMethod]
        public void chekaem_pass_fifififi_result2()
        {
            Assert.AreEqual(5, Program.chekaem_pass("fifififi"));
        }

        [TestMethod]
        public void chekaem_pass_fifIfiif_result3()
        {
            Assert.AreEqual(5, Program.chekaem_pass("fifIfiif"));
        }

        [TestMethod]
        public void chekaem_pass_fifIfiif_result4()
        {
            Assert.AreEqual(5, Program.chekaem_pass("fifIfi!f"));
        }

        [TestMethod]
        public void chekaem_pass_none_result0()
        {
            Assert.AreEqual(5, Program.chekaem_pass(""));
        }

        [TestMethod]
        public void chekaem_pass_emayEezdesvseest_result5()
        {
            Assert.AreEqual(5, Program.chekaem_pass("emayEe zdes vse est!! 2421"));
        }
}
