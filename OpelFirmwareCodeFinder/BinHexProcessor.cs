using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OpelDensoCodeFinder
{
    public class BinHexProcessor
    {
        public string FilePath  { get; private set; }
        public string UserInput { get; private set; }

        public BinHexProcessor(string filePath, string userInput)
        {
            FilePath  = filePath;
            UserInput = userInput;
        }

        public string Process()
        {
            string hex = ReadAndReverseBinFile(FilePath);
            if (NeedReverse(hex, UserInput))
            {
                hex = ReversePairsInHex(hex);
            }
            string result = SearchInHex(hex);
            return result;
        }

        private string ReadAndReverseBinFile(string filePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            Array.Reverse(fileBytes);
            string hex = BitConverter.ToString(fileBytes).Replace("-", string.Empty);
            return hex;
        }

        private bool NeedReverse(string hex, string userInput)
        {
            string userInputHex = string.Join("", Encoding.ASCII.GetBytes(userInput).Select(b => b.ToString("X2")));

            // Создаем шаблон поиска, где между каждой парой символов может быть любая пара символов
            string pattern = string.Join("..", userInputHex.Select((x, i) => i % 2 == 0 ? userInputHex.Substring(i, 2) : "")
                                                           .Where(x => !string.IsNullOrEmpty(x))
                                        );

            if (Regex.IsMatch(hex, pattern))
            {
                return false;
            }

            return true;
        }

        private string SearchInHex(string hex)
        {
            string sequence        = "00FF5AA500FF";
            string reverseSequence = string.Concat(sequence.Reverse());

            string code = null;
            if (hex.Contains(sequence))
            {
                code = hex.Substring(hex.IndexOf(sequence) + sequence.Length, 16);
            }
            else if (hex.Contains(reverseSequence))
            {
                code = hex.Substring(hex.IndexOf(reverseSequence) + reverseSequence.Length, 16);
            }

            if (code != null)
            {
                string asciiString = string.Join("", Enumerable.Range(0, code.Length / 2)
                                                               .Select(x => Convert.ToChar(Convert.ToUInt32(code.Substring(x * 2, 2), 16))));
                string digitPattern1 = new string(asciiString.Where((c, i) => i % 2 == 0 && char.IsDigit(c)).ToArray());
                string digitPattern2 = new string(asciiString.Where((c, i) => i % 2 != 0 && char.IsDigit(c)).ToArray());

                if (digitPattern1.Length == 4)
                {
                    return digitPattern1;
                }
                else if (digitPattern2.Length == 4)
                {
                    return digitPattern2;
                }
            }

            return "Not found";
        }

        private string ReversePairsInHex(string hex)
        {
            return string.Join("", Enumerable.Range(0, hex.Length)
                                             .Where(x => x % 2 == 0)
                                             .Reverse()
                                             .Select(x => hex.Substring(x, 2)));
        }
    }
}
