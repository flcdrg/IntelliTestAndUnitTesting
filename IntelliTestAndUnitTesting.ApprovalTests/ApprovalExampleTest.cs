using System;

using ApprovalTests;
using ApprovalTests.Reporters;

using NUnit.Framework;

namespace IntelliTestAndUnitTesting.ApprovalTests
{
    [TestFixture]
    public class ApprovalExampleTest
    {
        [Test]
        [UseReporter(typeof(BeyondCompareReporter))]
        public void TestList()
        {
            var names = new[] { "Llewellyn", "James", "Dan", "Jason", "Katrina" };
            Array.Sort(names);
            Approvals.VerifyAll(names, "");
        }

        [Test]
        [UseReporter(typeof(ImageReporter))]
        public void MapImages()
        {
            var service = new MapService();

            var filename = @"c:\tmp\image.jpg";
            service.GetMapImage(filename, -34.9859652, 138.7019549);

            Approvals.VerifyFile(filename);
        }
    }
}