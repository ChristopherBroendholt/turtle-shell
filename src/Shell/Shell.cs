namespace Turtle;

public static class Shell{

    public static bool Running { get; set; } = true;

    public static void Start(string[] args){

        Console.Clear();

        while(Running){
            string? command = CommandHandler.PromptCommand();
            CommandHandler.ParseCommand(command);
        }
    }
}