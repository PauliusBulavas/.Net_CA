using System;
using System.IO;

namespace PamokaSesiolika
{
    class Program
    {
        static void Main(string[] args)
        {
            var command     = args[0];

            if (command == "--file")
            {
                var filePath = args[1];
                Console.WriteLine($"Pasirinkta viena byla: {filePath}");
                ProcessSingleFile(filePath);
            }

            else if (command == "--dir")
            {
                var dirPath     = args[1];
                var fileType    = args[2];

                ProcessDirectory(dirPath, fileType)
            }
        }

        private static void ProcessDirectory(string dirPath, string fileType)
        {
            switch (fileType)
            {
                case "TEXT":
                        string[] textFiles = Directory.GetFiles(dirPath, "*.txt");

                    foreach (var textFile in textFiles)
                    {
                        Console.WriteLine(textFile);
                    }
                    break;
                default:
                    Console.WriteLine($"KLAIDA, tipas nepalaikomas! {fileType}");
                    break;
            }
        }

        private static void ProcessSingleFile(string filePath)
        {
            var fileProcessor = new FileProcessor(filePath);

            fileProcessor.Process();

        }
    }
}
