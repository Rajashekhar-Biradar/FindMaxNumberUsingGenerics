using FindMaxNumberUsingGenerics;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Integer_FindMaxNumber obj = new Integer_FindMaxNumber();
            object result = obj.Find_Max_num(200, 180, 60);
            Assert.AreEqual(200, result);  
        }

        [TestMethod]
        public void TestMethod2()
        {

            Integer_FindMaxNumber obj = new Integer_FindMaxNumber();
            object result = obj.Find_Max_num(100, 180, 60);
            Assert.AreEqual(180, result);
        }

        [TestMethod]
        public void TestMethod3()
        {

            Integer_FindMaxNumber obj = new Integer_FindMaxNumber();
            object result = obj.Find_Max_num(200, 180, 360);
            Assert.AreEqual(360, result);
        }


    }
}