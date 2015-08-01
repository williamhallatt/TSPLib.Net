﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using TspLibNet;

namespace TspLibNetTests
{
    [TestClass]
    public class TspLib95Tests
    {
        private const string RootDir = @"..\..\..\..\TSPLIB95";

        [TestMethod]
        public void LoadAllTSP()
        {
            var tspLib = new TspLib95(RootDir);
            tspLib.LoadAllTSP();
            var items = tspLib.TSPItems();
            Assert.AreEqual(items.Count(), 112);
        }

        [TestMethod]
        public void LoadAllATSP()
        {
            var tspLib = new TspLib95(RootDir);
            tspLib.LoadAllATSP();
            var items = tspLib.ATSPItems();
            Assert.AreEqual(items.Count(), 19);
        }

        [TestMethod]
        public void LoadAllHCP()
        {
            var tspLib = new TspLib95(RootDir);
            tspLib.LoadAllHCP();
            var items = tspLib.HCPItems();
            Assert.AreEqual(items.Count(), 9);
        }

        [TestMethod]
        public void LoadAllSOP()
        {
            var tspLib = new TspLib95(RootDir);
            tspLib.LoadAllSOP();
            var items = tspLib.SOPItems();
            Assert.AreEqual(items.Count(), 41);
        }

        [TestMethod]
        public void LoadAllCVRP()
        {
            var tspLib = new TspLib95(RootDir);
            tspLib.LoadAllCVRP();
            var items = tspLib.CVRPItems();
            Assert.AreEqual(items.Count(), 16);
        }
    }
}