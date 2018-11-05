using System;
using System.Collections.Generic;
using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DesignHashMapUnitTest
    {
        public MyHashMap myhashmap { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            myhashmap = new MyHashMap();
        }

        [TestCleanup]
        public void AfterEach()
        {
            myhashmap = null;
        }

        [TestMethod]
        public void DesignHashMapTestMethod()
        {
            myhashmap.Put(1, 1);
            myhashmap.Put(2, 2);
            Assert.AreEqual(1, myhashmap.Get(1));
            Assert.AreEqual(-1, myhashmap.Get(3));
            myhashmap.Put(2, 1);
            Assert.AreEqual(1, myhashmap.Get(2));
            myhashmap.Remove(2);
            Assert.AreEqual(-1, myhashmap.Get(2));
        }

        [TestMethod]
        public void DesignHashMapTestMethod2()
        {
            var expected = new List<object> { null, null, null, null, -1, null, null, -1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 90, null, -1, null, null, 40, null, null, null, null, null, 29, null, null, null, null, 17, null, null, null, null, null, null, null, null, null, 33, null, null, null, null, null, null, 18, null, null, -1, null, null, -1, 35, null, null, null, null, null, null, null, -1, -1, null, null, null, null, null, -1, null, null, null, null, null, null, null, null, null, null, null, null, null, -1, null, null, null, null, 87, null, null };
            var commandlist = new string[] { "remove", "put", "remove", "remove", "get", "remove", "put", "get", "remove", "put", "put", "put", "put", "put", "put", "put", "put", "put", "put", "put", "remove", "put", "put", "get", "put", "get", "put", "put", "get", "put", "remove", "remove", "put", "put", "get", "remove", "put", "put", "put", "get", "put", "put", "remove", "put", "remove", "remove", "remove", "put", "remove", "get", "put", "put", "put", "put", "remove", "put", "get", "put", "put", "get", "put", "remove", "get", "get", "remove", "put", "put", "put", "put", "put", "put", "get", "get", "remove", "put", "put", "put", "put", "get", "remove", "put", "put", "put", "put", "put", "put", "put", "put", "put", "put", "remove", "remove", "get", "remove", "put", "put", "remove", "get", "put", "put" };
            var inputs = new string[] { "27", "65,65", "19", "0", "18", "3", "42,0", "19", "42", "17,90", "31,76", "48,71", "5,50", "7,68", "73,74", "85,18", "74,95", "84,82", "59,29", "71,71", "42", "51,40", "33,76", "17", "89,95", "95", "30,31", "37,99", "51", "95,35", "65", "81", "61,46", "50,33", "59", "5", "75,89", "80,17", "35,94", "80", "19,68", "13,17", "70", "28,35", "99", "37", "13", "90,83", "41", "50", "29,98", "54,72", "6,8", "51,88", "13", "8,22", "85", "31,22", "60,9", "96", "6,35", "54", "15", "28", "51", "80,69", "58,92", "13,12", "91,56", "83,52", "8,48", "62", "54", "25", "36,4", "67,68", "83,36", "47,58", "82", "36", "30,85", "33,87", "42,18", "68,83", "50,53", "32,78", "48,90", "97,95", "13,8", "15,7", "5", "42", "20", "65", "57,9", "2,41", "6", "33", "16,44", "95,30" };

            for (int i = 0; i < commandlist.Length; i++)
            {
                if (commandlist[i] == "put")
                {
                    var command = inputs[i].Split(",");
                    var key = command[0];
                    var value = command[1];
                    myhashmap.Put(int.Parse(key), int.Parse(value));
                }
                else if (commandlist[i] == "remove")
                {
                    var key = int.Parse(inputs[i]);
                    myhashmap.Remove(key);
                }
                else if (commandlist[i] == "get")
                {
                    var key = int.Parse(inputs[i]);
                    var actual = myhashmap.Get(key);
                    if (actual == -1)
                    {
                        Assert.AreEqual(-1, expected[i]);
                    }
                    Assert.AreEqual((int)expected[i], actual);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

        }
    }
}