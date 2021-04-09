using System;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            if (inputStr.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                Environment.Exit(1);
            }

            int devidedLen = inputStr.Length / 2;

            int countEqual = 0;

            for (int i = 0; i < devidedLen; i++)
            {
                if ((inputStr[i] == '(') && (inputStr[inputStr.Length - 1 - i] == ')'))
                {
                    countEqual++;
                    continue;
                }
                else if ((inputStr[i] == '{') && (inputStr[inputStr.Length -1 - i] == '}') )
                {
                    countEqual++;
                    continue;
                }
                else if ((inputStr[i] == '[') && (inputStr[inputStr.Length - 1 - i] == ']'))
                {
                    countEqual++;
                    continue;
                }
                else if ((inputStr[i] == ' ') && (inputStr[inputStr.Length - 1 - i] == ' '))
                {
                    countEqual++;
                    continue;
                }

                Console.WriteLine("NO");
                break;
            }

            if (countEqual == devidedLen)
            {
                Console.WriteLine("YES");
            }            
        }
    }
}
