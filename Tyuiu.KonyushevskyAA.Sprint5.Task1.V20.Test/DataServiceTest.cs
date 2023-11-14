using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KonyushevskyAA.Sprint5.Task1.V20.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint5.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\lenovo\source\repos\Tyuiu.KonyushevskyAA.Sprint5\Tyuiu.KonyushevskyAA.Sprint5.Task1.V20\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
