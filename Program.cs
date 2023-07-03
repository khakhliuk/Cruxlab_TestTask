using System;
using System.Collections.Generic;
using System.IO;

namespace Cruxlab_TestTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("FileData.txt", FileMode.Open);
            FileParser fileParser = new FileParser(fileStream);
            List<FileData> parsedFileData = fileParser.ParseData();
            Console.WriteLine(PasswordValidator.Validate(parsedFileData));
            Console.ReadKey();
        }
    }
}