using System.Collections.Generic;
using NUnit.Framework;

public class DummyPlayTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void EmptyList()
    {
        // Assign
        List<int> emptyList;

        // Act
        emptyList = new List<int>();

        // Assert
        Assert.IsEmpty(emptyList);
    }
}
