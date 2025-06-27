public class Solution
{
    public static void Main()
    {
        var input = Console.ReadLine();

        if (input != null) {
            var result = Solution.Solve(input);
            Console.WriteLine(result);
        }
    }

    public static int Solve(string input)
    {
        var numbers = input.Split(" ").Select(int.Parse).ToArray();
        var n = numbers.Length + 1;
        var sum = (n-1) * n / 2;

        return sum - numbers.Sum();
    }
}
