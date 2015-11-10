using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using NUnit.Framework;

namespace FakeTestLib
{
    [TestFixture]
    class TheFakeTest
    {

        [Test]
        public void The_fake_test()
        {
            Assert.True(true);
        }
    }
}
