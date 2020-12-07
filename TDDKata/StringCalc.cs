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
                int sum = 0;

                string[] mas;

                if (input.StartsWith("//"))
                {
                    // Проверяем, что после кастомного сапаратора стоит разделитель \n
                    var endIndex = input.IndexOf('\n');
                    if (endIndex != 3)
                        return -1;

                    var separator = input[2];

                    // Удаляем начало строки с информацией о кастомной сепараторе
                    input = input.Substring(4);

                    mas = input.Split(separator);
                }
                else
                {
                    input = input.Replace('\n', ',');
                    mas = input.Split(',');
                }

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