using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KonyushevskyAA.Sprint5.Task3.V7.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint5.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\lenovo\source\repos\Tyuiu.KonyushevskyAA.Sprint5\Tyuiu.KonyushevskyAA.Sprint5.Task3.V7\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
