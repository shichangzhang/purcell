public interface IInput
{
    public int[] Read();
}

public class ConsoleInput : IInput
{
    public int[] Read()
    {
        var input = Console.ReadLine();

        if (input != null) {
            var numbers = input.Split(" ").Select(int.Parse).ToArray();
            return numbers;
        }
        return new int[0] {};
    }
}
