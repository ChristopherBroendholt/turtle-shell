using System.Diagnostics;
using System.Text;

namespace Turtle;

public static class WindowsCommands{


    public static void ParseCommand(string? command){
        if(!ValidCommand(command)){
            return;
        }

        var processInfo = new ProcessStartInfo("cmd.exe", $"/c {command}") 
        {
            CreateNoWindow = true,
            UseShellExecute = false,
            RedirectStandardError = true,
            RedirectStandardOutput = true,
            WorkingDirectory =  @"C:\Users\felsd\source\repos\turtle-shell\src" //should be a global variable for directory traversal
        };

        StringBuilder sb = new StringBuilder();
        Process p = Process.Start(processInfo);
        p.OutputDataReceived += (sender, args) => sb.AppendLine(args.Data);
        p.BeginOutputReadLine();
        p.WaitForExit();
        Console.WriteLine(sb.ToString());
        //do something

    }

    private static bool ValidCommand(string? command){
        if(String.IsNullOrEmpty(command)){
            return false;
        }
        return true;
    }
}