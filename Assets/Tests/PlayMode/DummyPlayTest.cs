using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine.TestTools;

public class DummyPlayTest
{
    // A Test behaves as an ordinary method
    [UnityTest]
    public IEnumerator EmptyList()
    {
        // Assign
        List<int> emptyList;

        // Act
        emptyList = new List<int>();

        // Assert
        Assert.IsEmpty(emptyList);
        yield return null;
    }
}
