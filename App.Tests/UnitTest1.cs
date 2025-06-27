using App;

namespace App.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int[] testInput = new[] { 3, 0, 1 };

        var result = Solution.Solve(testInput);

        Assert.Equal(2, result);
    }
}
