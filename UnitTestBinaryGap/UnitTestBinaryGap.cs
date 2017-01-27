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
