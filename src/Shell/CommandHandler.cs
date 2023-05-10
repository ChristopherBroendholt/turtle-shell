using Turtle.Writer;

namespace Turtle;

public static class CommandHandler{

    public static void ParseCommand(string? command){
        if(TurtleCommands.AvailableCommands().Any(x => x == command)){
            TurtleCommands.ParseCommand(command);
        }
        else{
            WindowsCommands.ParseCommand(command);
        }
    }

    public static string? PromptCommand(){
        WriterUtils.Write("> ", ConsoleColor.DarkGreen);
        return Console.ReadLine();
    }
}