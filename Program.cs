var input = Console.ReadLine();

if (input != null) {
    var numbers = input.Split(" ").Select(int.Parse).ToArray();
    var n = numbers.Length + 1;
    var sum = (n-1) * n / 2;

    Console.WriteLine(sum - numbers.Sum());
}
