namespace App;

public class Solution
{
    public static void Main()
    {
        IInput input = new ConsoleInput();
        IOutput output = new ConsoleOutput();

        var numbers = input.Read();

        var result = Solution.Solve(numbers);

        output.Write(result);
    }

    public static int Solve(int[] numbers)
    {
        var n = numbers.Length + 1;
        var sum = (n-1) * n / 2;

        return sum - numbers.Sum();
    }
}
