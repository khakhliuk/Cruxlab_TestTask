using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cruxlab_TestTask
{
    public static class PasswordValidator
    {
        public static int Validate(List<FileData> parsedData)
        {
            int validCount = 0;

            foreach (var data in parsedData)
            {
                int count = Regex.Matches(data.String, data.Symbol.ToString()).Count;
                if (count <= data.MaxCount && count >= data.MinCount)
                {
                    validCount++;
                }
            }
            
            return validCount;
        }
    }
}