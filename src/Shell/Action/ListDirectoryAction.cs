using Turtle.Writer;

namespace Turtle;

public static class ListDirectoryAction
{

	public static void ListDirectory()
	{

		string currentDir = Shell.CurrentDirectory;
		string[] files = Directory.GetFiles(currentDir);
		string[] directories = Directory.GetDirectories(currentDir);

		Console.WriteLine("Directory of " + currentDir);

		foreach (string directory in directories)
		{
			WriterUtils.Write($"{Path.GetFileName(directory)}	", ConsoleColor.Green);
		}

		foreach (string file in files)
		{
			WriterUtils.Write($"{Path.GetFileName(file)}	");
		}

		WriterUtils.Write(System.Environment.NewLine);
	}

}