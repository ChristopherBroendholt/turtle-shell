using Turtle.Writer;

namespace Turtle;

public static class DirectoryTraversalAction
{

	public static void Traverse(string[] arguments)
	{
		string currentDir = Shell.CurrentDirectory;
	
		if(Stay(arguments)){
			WriterUtils.Write($"Current directory: {Shell.CurrentDirectory}");
			WriterUtils.Write(System.Environment.NewLine);
			return;
		}

		if(Back(arguments)){
			string[] splittedCurrentDir = currentDir.Split("\\");
			Shell.CurrentDirectory = string.Join("\\", splittedCurrentDir.SkipLast(1)); 

			WriterUtils.Write($"Current directory: {Shell.CurrentDirectory}");
			WriterUtils.Write(System.Environment.NewLine);
			return;
		}

		if(Root(arguments)){
			string[] splittedCurrentDir = currentDir.Split("\\");
			Shell.CurrentDirectory = string.Join("\\", splittedCurrentDir.First()); 

			WriterUtils.Write($"Current directory: {Shell.CurrentDirectory}");
			WriterUtils.Write(System.Environment.NewLine);
			return;
		}

		if(Move(arguments)){
			WriterUtils.Write($"Current directory: {Shell.CurrentDirectory}");
			WriterUtils.Write(System.Environment.NewLine);
			return;
		}
		else{
			WriterUtils.Write("Path does not exists", textColor: ConsoleColor.Red);
			WriterUtils.Write(System.Environment.NewLine);
			return;
		}
	}

	private static bool Stay(string[] arguments){
		if(arguments.Length == 0){
			return true;
		}
		else if(arguments.First() == "."){
			return true;
		}
		else{
			return false;
		}
	}

	private static bool Back(string[] arguments){
		if(arguments.First() == ".."){
			return true;
		}
		else{
			return false;
		}
	}

	private static bool Root(string[] arguments){
		if(arguments.First() == "\\"){
			return true;
		}
		else{
			return false;
		}
	}

	private static bool Move(string[] arguments){
		string currentDir = Shell.CurrentDirectory;
		string[] newDirArr = currentDir.Split("\\");
        string[] splittedArgument = arguments.First().Split("\\");

		foreach(string pathElement in splittedArgument){
			Console.WriteLine(pathElement);

			if(pathElement == ".."){
				newDirArr = newDirArr.SkipLast(1).ToArray();
			}
			else{
				newDirArr = newDirArr.Append(pathElement).ToArray();
				//hovsa det skal også virke hvis et folder navn er flere ord :D
			}

		}

        string newDir = string.Join("\\", newDirArr);

        Console.WriteLine(newDir);

		if(Path.Exists(newDir)){
			Shell.CurrentDirectory = newDir;
			return true;
		}
		else{
			return false;
		}
	}
}