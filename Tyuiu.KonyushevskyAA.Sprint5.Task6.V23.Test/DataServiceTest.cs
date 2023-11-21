using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KonyushevskyAA.Sprint5.Task6.V23.Lib;


namespace Tyuiu.KonyushevskyAA.Sprint5.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint5\InPutDataFileTask6V23.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }


        public void CheckedExistsFile()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask6V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
