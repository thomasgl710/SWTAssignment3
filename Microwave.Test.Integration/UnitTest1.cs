using NUnit.Framework;

namespace Microwave.Test.Integration
{
    public class Tests
    {
        //wupti
        //heri kan der laves et setup der k�res hver gang inden test.
        [SetUp]
        public void Setup()
        {
        }
        //test
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public   void Test2()
        {
            //Hejhej
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            Assert.Pass();
        }
        [Test]
        public void Test4()
        {
            var hej = 4;
            Assert.That(hej, Is.EqualTo(4));
        }
    }
}