using System;
using System.IO;

namespace PamokaSesiolika
{
    public class FileProcessor
    {
        private static readonly string _backupDirName       = "backup";
        private static readonly string _inProgressDirName   = "processing";
        private static readonly string _completedDirName    = "completed";

        public string InputFilePath { get; private set; }

        public FileProcessor(){ }
        public FileProcessor(string filePath)
        {
            InputFilePath = filePath;
        }

        public void Process()
        {
            Console.WriteLine($"Pradedu bylos apdorojima: {InputFilePath}");

            if (!File.Exists(InputFilePath))
            {
                Console.WriteLine($"KLAIDA: {InputFilePath} 404!");
                return;
            }

            string rootDirPath = new DirectoryInfo(InputFilePath).Parent.Parent.FullName; //parent skaicius korealus kiek kartu nori grizti
            Console.WriteLine($"root katalogas: {rootDirPath}");

            string backupDirPath = Path.Combine(rootDirPath, _backupDirName);

            //reference 1
            if (!Directory.Exists(backupDirPath))
            {
                Console.WriteLine($"Kuriamas: {backupDirPath}");

                Directory.CreateDirectory(backupDirPath);
            }

            string inputFileName    = Path.GetFileName(InputFilePath);
            string backupFilePath   = Path.Combine(backupDirPath, inputFileName);

            Console.WriteLine($"Kopijuoju: {InputFilePath} i {backupFilePath}");

            File.Copy(InputFilePath, backupFilePath);

            //tasspats kas refference 1
            Directory.CreateDirectory(Path.Combine(rootDirPath, _inProgressDirName));

            string inProgressFilePath = Path.Combine(rootDirPath, _inProgressDirName, inputFileName);

            if (File.Exists(inProgressFilePath))
            {
                Console.WriteLine($"KLAIDA: byla {inProgressFilePath} jau apdorota!");
                return;
            }

            Console.WriteLine($"Perkeliu {InputFilePath} i {inProgressFilePath}");
            File.Move(InputFilePath, inProgressFilePath);

            string extension = Path.GetExtension(InputFilePath);

            switch (extension)
            {
                case ".txt":
                    ProcessTextFile(inProgressFilePath);
                    break;
                default:
                    Console.WriteLine($"Nepalaikomas failo tipas: {extension}");
                    break;
            }

            string completedDirPath = Path.Combine(rootDirPath, _completedDirName);
            Directory.CreateDirectory(completedDirPath);

            Console.WriteLine($"Perkelimas is {inProgressFilePath} i {completedDirPath}");
            var completedFileName = string.Format("{0}-{1}{2}", Path.GetFileNameWithoutExtension(InputFilePath), Guid.NewGuid(), extension);

            var completedFilePath = Path.Combine(completedDirPath, completedFileName);

            File.Move(inProgressFilePath, completedFilePath);

            string inProgressDirPath = Path.GetDirectoryName(inProgressFilePath);
            Directory.Delete(inProgressDirPath, true);
        }

        private void ProcessTextFile(string inProgressFilePath)
        {
            Console.WriteLine($"Apdorojama byla: {inProgressFilePath}");
            //read in and process
        }
    }
}
