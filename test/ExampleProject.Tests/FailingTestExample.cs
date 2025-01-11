namespace ExampleProject.Tests;

public class FailingTestExample
{
    [Fact]
    public void FailingTest()
    {
        Assert.True(false);
    }
}