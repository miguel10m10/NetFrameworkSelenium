using System;
using NUnit.Framework;

namespace ConsoleApp1.cursoNunit
{

    [TestFixture]
    public class EmptyClass
    {
        [Test]
        public void myMethod(){

            Assert.Fail();
        }
    }
}
