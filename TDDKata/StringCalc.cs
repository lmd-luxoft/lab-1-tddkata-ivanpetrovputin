// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Linq;

namespace TDDKata
{
    public class StringCalc
    {
        public int Sum(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1;

            try
            {
                input = input.Replace('\n', ',');
                var mas = input.Split(',');
                int sum = 0;

                foreach (var item in mas)
                {
                    if (!int.TryParse(item, out int n))
                        return -1;

                    if (n < 0)
                        return -1;

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