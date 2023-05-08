namespace Turtle;

public static class TurtleCommands{

    private static Dictionary<string, Action> Commands = new Dictionary<string, Action>(){
        {"exit", () => {Shell.Running = false; }}
    };

    public static void ParseCommand(string? command){
        if(!ValidCommand(command)){
            return;
        }

        Action action = Commands[command!];
        action();
    }

    private static bool ValidCommand(string? command){
        if(String.IsNullOrEmpty(command)){
            return false;
        }

        if(Commands.Any(x => x.Key == command)){
            return true;
        }
        
        return false;
    }

    public static string[] AvailableCommands(){
        return Commands.Keys.ToArray();
    }
}