using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITI.AlgorithmsTest
{
    [TestFixture]
    class simpleTest
    {
        [Test]
        public void SimpleTest()
        {
            Assert.That(1, Is.EqualTo(1));
        }
    }
}
