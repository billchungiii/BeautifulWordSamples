using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeautifulWordSample002;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulWordSample002.Tests
{
    [TestClass()]
    public class BeautifulWordExtensionTests
    {
        [DataRow("AA", true)]
        [DataRow("AAB", true)]
        [DataRow("BAA", true)]
        [DataRow("ABB", false)]
        [DataRow("BBA", false)]
        [DataRow("AaaBbC", true)]
        [DataRow("cbBaaA", true)]
        [DataRow("aBbbc", false)]
        [DataRow("baac", false)]
        [DataTestMethod()]
        public void IsBeautifulTest(string source, bool result) => Assert.AreEqual(result, source.IsBeautiful());
    }
}