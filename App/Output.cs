public interface IOutput
{
    public void Write();
}

public class ConsoleOutput : IOutput
{
    public void Write(string result)
    {
        Console.WriteLine(result);
    }
}
