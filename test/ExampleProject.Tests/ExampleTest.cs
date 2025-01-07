namespace ExampleProject.Tests;

public class ExampleTest
{
    [Fact]
    public void ExampleFailingTest()
    {
        const int x = 1;
        
        Assert.Equal(-1, x);
    }
}