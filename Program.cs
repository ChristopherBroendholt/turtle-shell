namespace Turtle;

public static class Shell{

    public static void Main(){
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;

        string[] name = new string[]{"T", "u", "r", "t", "l", "e", "-", "s", "h", "e", "l", "l"};

        
        for(int i = 0; i < name.Length; i++){
            if(i % 2 == 0){
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else{
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            Console.Write(name[i]);

            Thread.Sleep(100);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n🐢  The slowest shell available  🐢");

        Console.ForegroundColor = ConsoleColor.White;
    }
}

