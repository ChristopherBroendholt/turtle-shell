namespace Turtle.Writer;

public static class WriterUtils{

    private static void Reset(){
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
    }

    public static void Write(string text, ConsoleColor textColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black){
        Reset();

        Console.ForegroundColor = textColor;
        Console.BackgroundColor = backgroundColor;
        Console.Write(text);

        Reset();
    }

    public static void Write(string[] text, int delay){
        throw new NotImplementedException();
    }

    public static void Write(string[] text, int delay, ConsoleColor[] colors){
        throw new NotImplementedException();
    }
    
    public static void Write(string[] text, int delay, ConsoleColor textColor){
        throw new NotImplementedException();
    }

    public static void Write(string[] text, int delay, ConsoleColor textColor, ConsoleColor backgroundColor){
        throw new NotImplementedException();
    }


}