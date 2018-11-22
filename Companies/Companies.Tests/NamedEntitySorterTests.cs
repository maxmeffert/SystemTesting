using NUnit.Framework;
using Companies.Core.Model;
using Companies.Core.Sorting;

namespace Companies.Tests
{
    [TestFixture]
    public class NamedEntitySorterTests
    {
        private NamedEntitySorter _cut;

        [SetUp]
        public void Setup()
        {
            _cut = new NamedEntitySorter();
        }

        [Test]
        public void SortsByNameAcending()
        {
            var namedEntities = new NamedEntity[] {
                new NamedEntity {
                    Name = "A"
                },
                new NamedEntity {
                    Name = "D"
                },
                new NamedEntity {
                    Name = "C"
                },
                new NamedEntity {
                    Name = "B"
                },
            };

            var result = _cut.Sort(namedEntities);

            // Assert.That(result, Is.Ordered.By("Name").Descending); // part of the commit that provokes a regression
            Assert.That(result, Is.Ordered.By("Name").Ascending);
        }
    }
}