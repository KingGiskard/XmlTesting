using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            int[] data = { 20, 41, 38, 51, 98, 23, 13, 92, 91, 25, 17, 14, 40, 79, 51, 10, 15, 53, 64, 81 };
            test.sort(data, 0, 19);
            Console.Read();
        }

        void sort(int[] data, int lowIndex, int highIndex)
        {
            Console.Write("Entering sort: ");
            Console.Write(lowIndex);
            Console.Write(" ");
            Console.Write(highIndex);
            Console.Write("\n");

            if (lowIndex >= highIndex)
            {
                Console.Write("Exiting sort: ");
                Console.Write(lowIndex);
                Console.Write(" ");
                Console.Write(highIndex);
                Console.Write("\n");
                return;
            }

            int centerValue = data[highIndex];
            int centerIndex = lowIndex;
            int tempIndex = lowIndex;
            int tempValue;

            while (tempIndex < highIndex)
            {
                tempValue = data[tempIndex];
                if (tempValue < centerValue)
                {
                    data[tempIndex] = data[centerIndex];
                    data[centerIndex] = tempValue;
                    centerIndex = centerIndex + 1;
                }
                tempIndex = tempIndex + 1;
            }

            data[highIndex] = data[centerIndex];
            data[centerIndex] = centerValue;

            sort(data, lowIndex, centerIndex - 1);

            sort(data, centerIndex + 1, highIndex);

            Console.Write("Exiting sort: ");
            Console.Write(lowIndex);
            Console.Write(" ");
            Console.Write(highIndex);
            Console.Write("\n");
            return;
}
    }
}
