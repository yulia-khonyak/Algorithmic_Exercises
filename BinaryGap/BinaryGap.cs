using System;

namespace BinaryGap
{
    public class BinaryGap
    {
        public int GetLargestBinaryZeroGap(string binaryNumber)
        {
            string[] binaryNumberArray = Convert.ToString(binaryNumber).Split('1');

            int gapCount = 0;

            for (int i = 1; i < binaryNumberArray.Length - 1; i++)
            {
                var tempCount = binaryNumberArray[i].Length;

                if (tempCount > gapCount)
                {
                    gapCount = tempCount;
                }
            }
            return gapCount;
        }

        public string ConvertIntegerToBinary(int number)
        {
           return Convert.ToString(number, 2);
        }

        public int ConvertIntegerToBinaryAndGetLargestBinaryZeroGap(int number)
        {
            string binaryNumber = ConvertIntegerToBinary(number);
            return GetLargestBinaryZeroGap(binaryNumber);
        }
    }
}
