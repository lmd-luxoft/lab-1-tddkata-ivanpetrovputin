// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Linq;

namespace TDDKata
{
    public class StringCalc
    {
        private static readonly string[] DEFAULT_SEPARATORS = {",", "\n"}; 
        
        private static string[] SplitInput(string input)
        {
            string numbers = input;
            string[] separators = DEFAULT_SEPARATORS;
            if (IsInputWithCustomSeparators(input))
            {
                separators = new[] {input[2].ToString()};
                numbers = input.Substring(4);
            }
            return numbers.Split(separators, StringSplitOptions.None);
        }

        private static bool IsInputWithCustomSeparators(string input)
        {
            return input.StartsWith("//") && input.IndexOf('\n') == 3;
        }

        public int Sum(string input)
        {
            if (input == null)
                return -1;

            string[] items = SplitInput(input);
            try
            {
                int sum = 0;
                foreach (var item in items)
                {
                    if (!int.TryParse(item, out int n))
                        return -1;

                    if (n < 0)
                        return -1;

                    if (n > 1000)
                        continue;

                    sum += n;
                }

                return sum;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}