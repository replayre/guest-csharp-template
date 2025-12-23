public static class App
{
    public static void Start()
    {
        Console.WriteLine("Hello world!");

        re.Events.OnNet<Message>(
            "ping",
            (clientId, x) =>
            {
                re.Events.EmitNetTargeted("pong", clientId, x);
            }
        );
    }
}
