using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBinaryGap
{
    [TestClass]
    public class UnitTestBinaryGap
    {
        private readonly BinaryGap.BinaryGap _binaryGap = new BinaryGap.BinaryGap();

        [TestMethod]
        public void TestMethodConvertIntegerToBinary()
        {
            Assert.AreEqual("0", _binaryGap.ConvertIntegerToBinary(0));
            Assert.AreEqual("1", _binaryGap.ConvertIntegerToBinary(1));
            Assert.AreEqual("10", _binaryGap.ConvertIntegerToBinary(2));
            Assert.AreEqual("11", _binaryGap.ConvertIntegerToBinary(3));
            Assert.AreEqual("100", _binaryGap.ConvertIntegerToBinary(4));
            Assert.AreEqual("101", _binaryGap.ConvertIntegerToBinary(5));
            Assert.AreEqual("110", _binaryGap.ConvertIntegerToBinary(6));
            Assert.AreEqual("111", _binaryGap.ConvertIntegerToBinary(7));
            Assert.AreEqual("1000", _binaryGap.ConvertIntegerToBinary(8));
            Assert.AreEqual("1001", _binaryGap.ConvertIntegerToBinary(9));
            Assert.AreEqual("1010", _binaryGap.ConvertIntegerToBinary(10));
            Assert.AreEqual("1011", _binaryGap.ConvertIntegerToBinary(11));
            Assert.AreEqual("1100", _binaryGap.ConvertIntegerToBinary(12));
            Assert.AreEqual("1101", _binaryGap.ConvertIntegerToBinary(13));
            Assert.AreEqual("1110", _binaryGap.ConvertIntegerToBinary(14));
            Assert.AreEqual("1111", _binaryGap.ConvertIntegerToBinary(15));
        }

        [TestMethod]
        public void TestMethodGetLargestZeroBinaryGap()
        {
            Assert.AreEqual(2, _binaryGap.GetLargestBinaryZeroGap("1001"));
            Assert.AreEqual(4, _binaryGap.GetLargestBinaryZeroGap("1000010001"));
            Assert.AreEqual(1, _binaryGap.GetLargestBinaryZeroGap("10100"));
            Assert.AreEqual(0, _binaryGap.GetLargestBinaryZeroGap("1111"));
            Assert.AreEqual(2, _binaryGap.GetLargestBinaryZeroGap("10011"));
            Assert.AreEqual(3, _binaryGap.GetLargestBinaryZeroGap("1010001010"));
            Assert.AreEqual(6, _binaryGap.GetLargestBinaryZeroGap("1010000001"));
            Assert.AreEqual(0, _binaryGap.GetLargestBinaryZeroGap("1100000000"));
            Assert.AreEqual(3, _binaryGap.GetLargestBinaryZeroGap("01000100"));
            Assert.AreEqual(1, _binaryGap.GetLargestBinaryZeroGap("00011011"));
            Assert.AreEqual(5, _binaryGap.GetLargestBinaryZeroGap("1000001"));
            Assert.AreEqual(0, _binaryGap.GetLargestBinaryZeroGap("1110000"));
            Assert.AreEqual(2, _binaryGap.GetLargestBinaryZeroGap("110011"));
        }

        [TestMethod]
        public void TestMethodGetLargestZeroBinaryGapForRandomNumbers()
        {
            int[] numbers = {1, 5, 6, 9, 11, 15, 16, 19, 20, 42, 328, 1024, 1041, 1162, 51712, 561892, 66561, 6291457, 74901729, 805306373, 1073741825, 1376796946, 1610612737, 2147483647};

            int[] largestBinaryGap = {0, 1, 0, 2, 1, 0, 0, 2, 1, 1, 2, 0, 5, 3, 2, 3, 9, 20, 4, 25, 29, 5, 28, 0};

            for (var i = 0; i < numbers.Length; i++)
            {
                var binaryNumber = _binaryGap.ConvertIntegerToBinary(numbers[i]);
                var largestBinaryZeroGap = _binaryGap.GetLargestBinaryZeroGap(binaryNumber);
                Assert.AreEqual(largestBinaryGap[i], largestBinaryZeroGap);
            }
        }
    }
}


/*  Task description

BinaryGap
Find longest sequence of zeros in binary representation of an integer.

A binary gap within a positive integer N is any maximal sequence of consecutive zeros 
that is surrounded by ones at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2.
The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. 
The number 20 has binary representation 10100 and contains one binary gap of length 1. 
The number 15 has binary representation 1111 and has no binary gaps.

Write a function:
class Solution { public int solution(int N); }

that, given a positive integer N, returns the length of its longest binary gap. 
The function should return 0 if N doesn't contain a binary gap.

For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 
and so its longest binary gap is of length 5.

Assume that:

N is an integer within the range [1..2,147,483,647].
Complexity:

expected worst-case time complexity is O(log(N));
expected worst-case space complexity is O(1).
*/

