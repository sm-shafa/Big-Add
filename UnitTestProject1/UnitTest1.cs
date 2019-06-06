using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigAdd;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            AddBig ad = new AddBig();
            string num1 = "123456784987654839874563211789";
            string num2 = "987654123357489612458556231025";
            string result = "";

            result = ad.Add(num1, num2);

            Assert.AreEqual(result, "1111110908345144452333119442814");
        }

        [TestMethod]
        public void TestMultiAdd()
        {
            //add more than two number
            List<string> mylist = new List<string>(new string[] { "121556550", "15589455452", "2254564555565552", "5554525455454554565" });
            AddBig myad = new AddBig();
            //5556780035721132119

            string multiResult = myad.MultiAdd(mylist);
            Assert.AreEqual(multiResult, "5556780035721132119");
        }
    }
}
