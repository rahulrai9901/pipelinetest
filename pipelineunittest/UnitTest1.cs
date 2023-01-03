namespace pipelineunittest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var result = false;
        if(1+1 == 2)
        {
            result = true;
        }
        Assert.IsTrue(result, "test is passed");
    }
}
