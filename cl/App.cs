public static class App
{
    public static void Start()
    {
        Console.WriteLine("Hello world!");

        re.Con.RegisterCommand(
            "ping",
            x =>
            {
                re.Events.EmitNet("ping", new Message(x.FirstOrDefault() ?? ""));
            }
        );

        re.Events.OnNet<Message>(
            "pong",
            x =>
            {
                Console.WriteLine($"Event received: {x.Text}");
            }
        );
    }
}
