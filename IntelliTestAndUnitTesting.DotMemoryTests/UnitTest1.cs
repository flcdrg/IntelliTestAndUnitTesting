using System;

using JetBrains.dotMemoryUnit;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntelliTestAndUnitTesting.DotMemoryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DotMemoryUnit(CollectAllocations = true)]
        public void TestMethod1()
        {
            var checkPoint = dotMemory.Check();

            var s = new Something();
            var t = new Something[5];

            dotMemory.Check(memory =>
            {
                Assert.AreEqual(2, memory.GetDifference(checkPoint)
                    .GetNewObjects().GetObjects(where => where.Namespace.Like("IntelliTestAndUnitTesting.DotMemoryTests")).ObjectsCount);
            });

            Console.WriteLine(s);

        }

        class Something
        {
            
        }
    }
}
