﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KonyushevskyAA.Sprint5.Task7.V17.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint5.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedExistsFile()
        {
            string path = $@"C:\DataSprint5\InPutDataFileTask7V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
