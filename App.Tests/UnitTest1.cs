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

    [Fact]
    public void Test2()
    {
        int[] testInput = new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

        var result = Solution.Solve(testInput);

        Assert.Equal(8, result);
    }
}
