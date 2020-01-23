using NUnit.Framework;
using ITI.Algorithms;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.AlgorithmsTest
{
    [TestFixture]
    public class exercice2_1Tests
    {
        [TestCase("abc",false)]
        [TestCase("dfdaae",true)]
        [TestCase("",false)]
        [TestCase("dnenfionef",true)]
        public void exercice2_1_Work(string s, bool b)
        {
            //Api fluent de Nunit
            //Assert.AreEqual(Exercice2_1.ContainsDuplicateChar(s), b);
            Assert.AreEqual(Exercice2_1.ContainsDuplicateChar_version2(s), b);
        }
    }
}
