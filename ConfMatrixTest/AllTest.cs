using NUnit.Framework;
using ConfMatrix;

namespace ConfMatrixTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //  TP = 20  FP = 30   FN = 40   TN = 50
        Calc calc = new Calc("20", "30", "40", "50");

        [Test]
        public void AccuracyTest()
        {
            float expected = 0.428571433f;
            float actual = calc.accuracy();
            Assert.AreEqual(expected, actual);
            //Assert.Pass();
        }

        [Test]
        public void PrecisionTest()
        {
            float expected = 0.400000006f;
            float actual = calc.precision();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SensitivityTest()
        {
            float expected = 0.285714298f;
            float actual = calc.sensitivity();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SpecificityTest()
        {
            float expected = 0.571428597f;
            float actual = calc.specificity();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void F1ScoreTest()
        {
            float expected = 0.333333343f;
            float actual = calc.f1Score();
            Assert.AreEqual(expected, actual);
        }

        //for all null values
        Calc ZeroInput = new Calc("0", "0", "0", "0");
        [Test]
        public void AccuracyForZeroInputTest()
        {
            float expected = 0.0f;
            float actual = ZeroInput.accuracy();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrecisionForZeroInputTest()
        {
            float expected = 0.0f;
            float actual = ZeroInput.precision();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SensitivityForZeroInputTest()
        {
            float expected = 0.0f;
            float actual = ZeroInput.sensitivity();
            Assert.AreEqual(expected, actual);
        }

        // for character input values
        Calc CharInput = new Calc("M", "N", "O", "P");

        [Test]
        public void AccuracyForCharInputTest()
        {
            float expected = -1.0f;
            float actual = CharInput.accuracy();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrecisionForCharInputTest()
        {
            float expected = -1.0f;
            float actual = CharInput.precision();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SensitivityForCharInputTest()
        {
            float expected = -1.0f;
            float actual = CharInput.sensitivity();
            Assert.AreEqual(expected, actual);
        }

        // for any blank input
      
        [Test]
        public void AccuracyForBlankInputTest()
        {
            Calc BlankInput = new Calc("20", "", "40", "50");
            float expected = 0.0f;
            float actual = BlankInput.accuracy();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrecisionForBlankInputTest()
        {
            Calc BlankInput = new Calc("20", "30", "", "50");
            float expected = 0.0f;
            float actual = BlankInput.precision();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SensitivityForBlankInputTest()
        {
            Calc BlankInput = new Calc("", "30", "", "50");
            float expected = 0.0f;
            float actual = BlankInput.sensitivity();
            Assert.AreEqual(expected, actual);
        }

        // for large input values
        Calc LargeInput = new Calc("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb", "66666666666666666666777777", "3333333333333333333333333333333333333333");

        [Test]
        public void AccuracyForLargeInputTest()
        {
            float expected = -1.0f;
            float actual = LargeInput.accuracy();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PrecisionForLargeInputTest()
        {
            float expected = -1.0f;
            float actual = LargeInput.precision();
            Assert.AreEqual(expected, actual);
        }






    }
}