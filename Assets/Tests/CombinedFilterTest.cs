using NUnit.Framework;
using UnityEngine;

public class CombinedFilterTest
{
    // A basic unit test with test values.
    [Test]
    public void CombinedFilterSimple()
    {
        int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
        int[] output = CombinedFilter.combinedFilter(input);
        int[] expected = { 0, 8, 0, 27, 25, 0, 40, 61, 51, 24 };

        CollectionAssert.AreEqual(expected, output);
    }
}
