using NDepend.Path;
using NUnit.Framework;
using System;

namespace BuildDependencyDocumentParser.Tests
{
    [TestFixture]
    public class BuildDependencyDocumentParserTests
    {
        [Test]
        public void Parse_WhenDocumentFilePathIsNull_ShouldThrowArgumentNullException()
        {
            var sut = new Core.BuildDependencyDocumentParser.BuildDependencyDocumentParser();

            Assert.Throws<ArgumentNullException>(() => sut.Parse(null));
        }

        [Test]
        public void Parse_WhenExtensionIsInvalid_ShouldThrowArgumentException()
        {
            var sut = new Core.BuildDependencyDocumentParser.BuildDependencyDocumentParser();
            var path = PathHelpers.ToFilePath(@"C:\Testing.asd");

            Assert.Throws<ArgumentException>(() => sut.Parse(path));
        }

        [Test]
        public void Parse_WhenThereIsNoExtension_ShouldThrowArgumentException()
        {
            var sut = new Core.BuildDependencyDocumentParser.BuildDependencyDocumentParser();
            var path = PathHelpers.ToFilePath(@"C:\Testing");

            Assert.Throws<ArgumentException>(() => sut.Parse(path));
        }

        [Test]
        public void Parse_WhenExtensionIsValid_ShouldSucceed()
        {
            var sut = new Core.BuildDependencyDocumentParser.BuildDependencyDocumentParser();
            var path = PathHelpers.ToFilePath(@"C:\SomeBuildDependencyDocument.bdd");

            sut.Parse(path);
        }
    }
}
