using Turtle.Writer;

namespace Turtle;

public static class CommandHandler{

    public static void ParseCommand(string? command){
        TurtleCommands.ParseCommand(command);
    }

    public static string? PromptCommand(){
        WriterUtils.Write("> ", ConsoleColor.DarkGreen);
        return Console.ReadLine();
    }
}