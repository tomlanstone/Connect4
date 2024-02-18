using Connect4;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleService Interactor = new ConsoleService();
        Player Player1 = new Player(1, "Aqua", Interactor);
        Console.WriteLine("Hello, {0}!", [Player1.PlayerName]);
    }
}