using Microsoft.VisualStudio.TestTools.UnitTesting;
using BeautifulWordSample001;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeautifulWordSample001.Tests
{
    [TestClass()]
    public class BeautifulWordExtensionTests
    {
        [DataRow ("AA", true)]
        [DataRow("AAB", true)]
        [DataRow("BAA", true)]
        [DataRow("ABB", false)]
        [DataRow("BBA", false)]
        [DataRow("AaaBbC", true)]
        [DataRow("cbBaaA", true)]
        [DataRow("aBbbc", false)]
        [DataRow("baac", false)]
        [DataTestMethod ()]
        public void IsBeautifulTest(string source, bool result) => Assert.AreEqual(source.IsBeautiful(), result);
    }
}