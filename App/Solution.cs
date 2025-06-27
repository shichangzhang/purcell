namespace App;

public class Solution
{
    public static void Main()
    {
        var input = Console.ReadLine();

        if (input != null) {
            var numbers = input.Split(" ").Select(int.Parse).ToArray();
            var result = Solution.Solve(numbers);
            Console.WriteLine(result);
        }
    }

    public static int Solve(int[] numbers)
    {
        var n = numbers.Length + 1;
        var sum = (n-1) * n / 2;

        return sum - numbers.Sum();
    }
}
