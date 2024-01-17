using System;
using System.IO;

class Program
{
    static void Main()
    {
        string sourcePath = @"E:\b"; // replace with your source folder path
        string destinationPath = @"E:\a"; // replace with your destination folder path

        if (!Directory.Exists(sourcePath))
        {
            Console.WriteLine($"Sourcee directoryy '{sourcePath}' does not exist.");
            return;
        }

        if (!Directory.Exists(destinationPath))
        {
            Directory.CreateDirectory(destinationPath);
        }

        string[] sourceFiles = Directory.GetFiles(sourcePath);

        string[] destinationFiles = Directory.GetFiles(destinationPath);

        for (int i = 0; i < Math.Min(sourceFiles.Length, destinationFiles.Length); i++)
        {
            string sourceFileName = Path.GetFileName(sourceFiles[i]);

            string destinationFilePath = Path.Combine(destinationPath, sourceFileName);

            // Rename the file without moving or copying it
            File.Move(destinationFiles[i], destinationFilePath);

            Console.WriteLine($"File '{destinationFiles[i]}' renamed to '{sourceFileName}' in '{destinationPath}'.");
        }

        Console.WriteLine("Renaming files in destination completed without modifying source files.");
    }
}
