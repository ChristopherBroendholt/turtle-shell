using Turtle.Writer.Art;

namespace Turtle;

public static class Program{

    public static void Main(string[] args){
        bool debug = true; 
        if (!debug){
            TurtleArt.Startup();
        }

        Shell.Start(args);

    }
}

