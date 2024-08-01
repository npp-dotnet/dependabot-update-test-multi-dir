namespace Hello.World.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Hello, World!", Greeter.Greet());
    }
}