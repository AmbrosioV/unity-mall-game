using NUnit.Framework;

public class DummyUnitTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void OnePlusOneEqualsTwo()
    {
        // Assign
        const int one = 1;

        // Act
        const int sum = one + one;

        // Assert
        Assert.AreEqual(sum, 2);
    }
}
