namespace Turtle;

public static class TurtleCommands{

    private static string CommandRoot = string.Empty;
    private static string[] CommandArguments = { "" };

    private static Dictionary<string, Action> Commands = new Dictionary<string, Action>(){
        {"exit", () => {Shell.Running = false; }},
        {"ls", () => {ListDirectoryAction.ListDirectory(); }},
        {"dir", () => {ListDirectoryAction.ListDirectory(); }},
        {"cd", () => {DirectoryTraversalAction.Traverse(CommandArguments); } }
    };

    public static void ParseCommand(string? command){
        if(command == null){
            return;
        }
        
        CommandRoot = command.Split(" ").First();
        CommandArguments = command.Split(" ").Skip(1).ToArray();

        if(!ValidCommand(CommandRoot)){
            return;
        }

        Action action = Commands[CommandRoot];
        action();
    }

    private static bool ValidCommand(string? commandRoot){
        if(String.IsNullOrEmpty(commandRoot)){
            return false;
        }

        if(Commands.Any(x => x.Key == commandRoot)){
            return true;
        }
        
        return false;
    }
}