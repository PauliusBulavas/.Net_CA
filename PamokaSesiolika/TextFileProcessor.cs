using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PamokaSesiolika
{
    class TextFileProcessor
    {
        public string InputFilePath     { get; }
        public string OutputFilePath    { get; }

        public TextFileProcessor(string inputFilePath, string outputFilePath)
        {
            OutputFilePath  = outputFilePath;
            InputFilePath   = inputFilePath;
        }

        public void Process()
        {
            string originalText = File.ReadAllText(InputFilePath);
            string processedText = originalText.ToUpperInvariant();

            File.WriteAllText(OutputFilePath, processedText);
        }
    }
}
