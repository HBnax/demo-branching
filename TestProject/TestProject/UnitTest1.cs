namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void FalseIsFalseAndStringIsEmpty()
    {
        // this was stupid
        Assert.False(!true);
        Assert.Empty("");
        Assert.True(!false);
    }
}
