namespace OpenShock.Common.ASPNET.Tests;

public class DummyTest
{
    [Test]
    public async Task TrueIsTrue()
    {
        bool value = true;
        
        // Assert
        await Assert.That(value).IsTrue();
    }
}