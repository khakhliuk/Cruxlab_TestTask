using System.Collections.Generic;
using System.IO;

namespace Cruxlab_TestTask
{
    public class FileParser
    {
        private readonly Stream _dataStream;
        private readonly List<FileData> _parsedData;

        public FileParser(Stream stream)
        {
            _dataStream = stream;
            _parsedData = new List<FileData>();
        }

        public List<FileData> ParseData()
        {
            using (StreamReader reader = new StreamReader(_dataStream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] splitLines = line.Split(' ');
                    string[] trimNums = splitLines[ParserConstants.RangeIndex].Split('-', ':');

                    FileData fileData = new FileData
                    {
                        Symbol = char.Parse(splitLines[ParserConstants.SymbolIndex]),
                        MinCount = int.Parse(trimNums[ParserConstants.MinNumberIndex]),
                        MaxCount = int.Parse(trimNums[ParserConstants.MaxNumberIndex]),
                        String = splitLines[ParserConstants.StringIndex]
                    };
                    
                    _parsedData.Add(fileData);
                }
            }

            return _parsedData;
        }
    }
}