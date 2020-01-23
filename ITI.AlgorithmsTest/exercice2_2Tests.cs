using ITI.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.AlgorithmsTest
{
    [TestFixture]
    public class Exercice2_2Tests
    {
        [TestCase("abcdf","fbcda",true)]
        [TestCase("advvcg","advvcg",false)]
        [TestCase("bobvr","nocew",false)]
        [TestCase("","",true)]
        public void exercice2_2work(string s1, string s2,bool b)
        {
            Assert.AreEqual(Exercice2_2.PernutedStrings(s1,s2), b);
        }
    }
}
