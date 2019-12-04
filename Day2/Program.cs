using System;
using System.IO;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string intCode = File.ReadAllLines(@"../../../input.txt")[0];
            string[] opCodesStr = intCode.Split(',');

            /* Convert the string array to int array so I don't
            / need to do the conversion in the while loop below. */
            int[] opCodes = Array.ConvertAll(opCodesStr, int.Parse);

            // replace position 1 with the value 12 and replace position 2 with the value 2
            opCodes[1] = 12;
            opCodes[2] = 2;

            FormProgram(opCodes);

            Console.WriteLine(opCodes[0]);
        }

        private static void FormProgram(int[] opCodes)
        {
            int opCodePosition = 0;
            int value = 0;

            while (opCodes[opCodePosition] != 99)
            {
                int position1 = opCodes[opCodePosition + 1];
                int position2 = opCodes[opCodePosition + 2];
                int position3 = opCodes[opCodePosition + 3];

                if (opCodes[opCodePosition] == 1)
                {
                    value = opCodes[position1] + opCodes[position2];
                }
                else if (opCodes[opCodePosition] == 2)
                {
                    value = opCodes[position1] * opCodes[position2];
                }

                opCodes[position3] = value;

                opCodePosition += 4;
            }
        }
    }
}
