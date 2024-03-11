using XPS.Common.Extensions;

namespace XPS.Common.UnitTests.Extensions;

[TestClass]
public class IntExtensionTests
{
    [DataTestMethod]
    [DataRow(1, "1")]
    [DataRow(11, "10,1")]
    [DataRow(111, "100,10,1")]
    [DataRow(1111, "1000,100,10,1")]
    [DataRow(9999, "9000,900,90,9")]
    [DataRow(4287, "4000,200,80,7")]
    public void ToDecimalUnitsCollection_WhenValidIntegerSupplied_ThenCorrectAmountsReturned(int i, string expectedResultString)
    {
        var expectedResults = expectedResultString.Split(',').Select(int.Parse).ToArray() ?? [];

        var actual = i.ToDecimalUnitsArray();

        CollectionAssert.AreEquivalent(expectedResults, actual);
    }

    [DataTestMethod]
    [DataRow(10, "10")]
    [DataRow(100, "100")]
    [DataRow(1000, "1000")]
    [DataRow(1001, "1000,1")]
    public void ToDecimalUnitsArray_WhenValidIntWithSomeZerosSupplied_ThenZerosOmittedFromListReturned(int i, string expectedResultString)
    {
        var expectedResults = expectedResultString.Split(',').Select(int.Parse).ToArray() ?? [];

        var actual = i.ToDecimalUnitsArray();

        CollectionAssert.AreEquivalent(expectedResults, actual);
    }

    [TestMethod]
    public void ToDecimalUnitsCollection_WhenZeroIntegerSupplied_ThenEmptyArrayIsReturned()
    {
        var expectedResults = Array.Empty<int>();

        var actual = 0.ToDecimalUnitsArray();

        CollectionAssert.AreEquivalent(expectedResults, actual);
    }

    [DataTestMethod]
    [DataRow(-1)]
    [DataRow(-100001)]
    public void ToDecimalUnitsCollection_WhenNegativeIntegerSupplied_ThenEmptyArrayIsReturned(int i)
    {
        var expectedResults = Array.Empty<int>();

        var actual = i.ToDecimalUnitsArray();

        CollectionAssert.AreEquivalent(expectedResults, actual);
    }
}