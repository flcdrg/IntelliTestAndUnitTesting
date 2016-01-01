using NUnit.Framework;

using Ploeh.AutoFixture;

namespace CustomUnitTests
{
    [TestFixture]
    public class AutoFixtureTests
    {
        [Test]
        public void NumbersExample()
        {
            var fixture = new Fixture();

            var number = fixture.Create<int>();

            Assert.That(number > 0);
        }

        [Test]
        public void BuildExample()
        {
            var fixture = new Fixture();

            var person = fixture.Build<Person>()
                .Without(p => p.Lastname)
                .Create();

            Assert.IsNotNull(person);
        }

    }

    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
