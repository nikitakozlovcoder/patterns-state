// See https://aka.ms/new-console-template for more information

using Lab3.Services.Cameras;

namespace Lab3;

internal static class EntryPoint
{
    private static void Main(string[] args)
    {
        var ct = new CancellationTokenSource();
        var camera = new Camera();
        var task = camera.Operate(ct.Token);
        Console.WriteLine("1 - Change state");
        Console.WriteLine("2 - Pause");
        Console.WriteLine("3 - to exit");
        string? input;
        while ((input = Console.ReadLine()?.ToLower()) != "3")
        {
            switch (input)
            {
                case "1":
                    camera.ChangeState();
                    break;
                case "2":
                    camera.Pause();
                    break;
            }
        }
        ct.Cancel();
        task.GetAwaiter().GetResult();
    }
}