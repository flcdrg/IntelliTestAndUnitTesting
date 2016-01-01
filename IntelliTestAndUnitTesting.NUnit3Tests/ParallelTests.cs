using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

using NUnit.Framework;

namespace IntelliTestAndUnitTesting.NUnit3Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public class ParallelTests
    {
        private static IList<int> RandomTimes()
        {
            var list = new List<int>();
            var random = new Random();
            for (int i = 0; i < 3; i++)
            {
                var time = random.Next(5000);
                list.Add(time);
            }

            return list;
        }

        [Test]
        [TestCaseSource(nameof(RandomTimes))]
        public void Test1(int time)
        {
            Thread.Sleep(time);
            TestContext.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}