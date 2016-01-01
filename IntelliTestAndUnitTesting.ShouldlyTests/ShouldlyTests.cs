using System;

using NUnit.Framework;

using Shouldly;

namespace IntelliTestAndUnitTesting.ShouldlyTests
{
    [TestFixture]
    public class ShouldlyTests
    {
        [Test]
        public void ExampleOld()
        {
            var s = DateTimeOffset.UtcNow.ToString();

            Assert.That(s, Is.StringContaining("**"), "Didn't expect that");
        }

        [Test]
        public void ExampleNew()
        {
            var s = DateTimeOffset.UtcNow.ToString();

            s.ShouldContain("**", "Didn't expect that");
        }

        [Test]
        public void AnotherExample()
        {
            var player = new Contestant();

            player.Score.ShouldBe(42);
        }

        public class Contestant
        {
            public int Score { get; set; }
        }
    }
}
