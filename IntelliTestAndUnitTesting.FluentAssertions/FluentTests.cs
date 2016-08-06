using System.Xml.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntelliTestAndUnitTesting.FluentAssertions
{
    [TestClass]
    public class FluentTests
    {
        [TestMethod]
        public void Strings()
        {
            string actual = "ABCDEFGHI";
            actual.Should().StartWith("AB").And.EndWith("HI").And.Contain("EF").And.HaveLength(9);
        }

        [TestMethod]
        public void Collections()
        {
            var collection = new[] { 1, 2, 3 };
            collection.Should().HaveCount(4, "because we thought we put three items in the collection");
        }

        [TestMethod]
        public void XmlDocument1()
        {
            var document = XDocument.Parse(@"<child />");

            document.Should().HaveElement("child")
                .Which.Should().BeOfType<XElement>()
                .And.HaveAttribute("attr", "1");
        }

        [TestMethod]
        public void XmlDocument2()
        {
            var document = XDocument.Parse(@"<parent><child /></parent>");

            document.Should().HaveElement("child")
                .Which.Should().BeOfType<XElement>()
                .And.HaveAttribute("attr", "1");
        }

        [TestMethod]
        public void XmlDocument3()
        {
            var document = XDocument.Parse(@"<parent><child attr='2' /></parent>");

            document.Should().HaveElement("child")
                .Which.Should().BeOfType<XElement>()
                .And.HaveAttribute("attr", "1");
        }

        [TestMethod]
        public void XmlDocument4()
        {
            var document = XDocument.Parse(@"<parent><child attr='1' /></parent>");

            document.Should().HaveElement("child")
                .Which.Should().BeOfType<XElement>()
                .And.HaveAttribute("attr", "1");
        }

    }
}
