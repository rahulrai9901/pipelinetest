using pipelinetest.Modules;

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
        if (1 + 1 == 2)
        {
            result = true;
        }
        Assert.IsTrue(result, "test is passed");

    }

    [Test]
    public void Test2()
    {
        var x = new AddFunction();
        int r = x.Add(2, 3);
        Assert.That(r, Is.EqualTo(5), "test is passed");

    }
}
