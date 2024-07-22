namespace test_explorer
{
    [TestClass]
    public class UnitTest21
    {
        private Calculator? _calculator;

        [TestInitialize]
        public void Initialize()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(0, 0, 0)]
        [DataRow(-1, -1, -2)]
        [DataRow(100, 200, 300)]
        public void TestAddition(int a, int b, int expected)
        {
            var result = _calculator?.Add(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(2, 3, 6)]
        [DataRow(0, 5, 0)]
        [DataRow(-2, -3, 6)]
        [DataRow(100, 0, 0)]
        public void TestMultiplication(int a, int b, int expected)
        {
            var result = _calculator?.Multiply(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(2, 3, 8)]
        [DataRow(5, 0, 1)]
        [DataRow(0, 5, 0)]
        [DataRow(3, 2, 9)]
        public void TestPower(double baseValue, double exponent, double expected)
        {
            var result = _calculator?.Power(baseValue, exponent) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAddition()
        {
            int result = _calculator?.Add(2, 3) ?? 0;
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestAdditionWithNegativeNumbers()
        {
            int result = _calculator?.Add(-2, -3) ?? 0;
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void TestAdditionWithZero()
        {
            int result = _calculator?.Add(0, 3) ?? 0;
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestAdditionBoundary()
        {
            int result = _calculator?.Add(int.MaxValue, 1) ?? 0;
            Assert.AreEqual(int.MinValue, result);  // Overflow
        }

        [TestMethod]
        public void TestAdditionZeroResult()
        {
            int result = _calculator?.Add(-5, 5) ?? 0;
            Assert.AreEqual(0, result);
        }

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(-1, 1, 0)]
        [DataRow(-2, -3, -5)]
        [DataRow(0, 0, 0)]
        public void TestAdditionTheory(int a, int b, int expected)
        {
            int result = _calculator?.Add(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(3, 4, 7)]
        [DataRow(10, 20, 30)]
        public void TestAdditionTheory2(int a, int b, int expected)
        {
            int result = _calculator?.Add(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(100, 200, 300)]
        [DataRow(200, 400, 600)]
        public void TestAdditionTheory3(int a, int b, int expected)
        {
            int result = _calculator?.Add(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            int result = _calculator?.Subtract(5, 3) ?? 0;
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestSubtractionWithNegativeNumbers()
        {
            int result = _calculator?.Subtract(-5, -3) ?? 0;
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestSubtractionWithZero()
        {
            int result = _calculator?.Subtract(0, 3) ?? 0;
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void TestSubtractionBoundary()
        {
            int result = _calculator?.Subtract(int.MinValue, 1) ?? 0;
            Assert.AreEqual(int.MaxValue, result);  // Underflow
        }

        [TestMethod]
        public void TestSubtractionZeroResult()
        {
            int result = _calculator?.Subtract(5, 5) ?? 0;
            Assert.AreEqual(0, result);
        }

        [DataTestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(20, 10, 10)]
        public void TestSubtractionTheory(int a, int b, int expected)
        {
            int result = _calculator?.Subtract(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAdditionOverZero()
        {
            int result = _calculator?.Add(5, -5) ?? 0;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSubtractionBelowZero()
        {
            int result = _calculator?.Subtract(-5, 5) ?? 0;
            Assert.AreEqual(-10, result);
        }

        [DataTestMethod]
        [DataRow(5, 5, 0)]
        [DataRow(-5, -5, 0)]
        public void TestSubtractionTheory2(int a, int b, int expected)
        {
            int result = _calculator?.Subtract(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAdditionPositiveOverflow()
        {
            int result = _calculator?.Add(int.MaxValue, 1) ?? 0;
            Assert.AreEqual(int.MinValue, result); // Overflow
        }

        [TestMethod]
        public void TestAdditionNegativeOverflow()
        {
            int result = _calculator?.Add(int.MinValue, -1) ?? 0;
            Assert.AreEqual(int.MaxValue, result); // Underflow
        }

        [TestMethod]
        public void TestAdditionLargeNumbers()
        {
            int result = _calculator?.Add(100000, 200000) ?? 0;
            Assert.AreEqual(300000, result);
        }

        [TestMethod]
        public void TestAdditionSmallNumbers()
        {
            int result = _calculator?.Add(1, 1) ?? 0;
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestAdditionMixedSigns()
        {
            int result = _calculator?.Add(-5, 10) ?? 0;
            Assert.AreEqual(5, result);
        }

        [DataTestMethod]
        [DataRow(3, 7, 10)]
        [DataRow(10, -5, 5)]
        public void TestAdditionTheory4(int a, int b, int expected)
        {
            int result = _calculator?.Add(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(50, 50, 100)]
        [DataRow(30, 70, 100)]
        public void TestAdditionTheory5(int a, int b, int expected)
        {
            int result = _calculator?.Add(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSubtractionPositiveUnderflow()
        {
            int result = _calculator?.Subtract(int.MinValue, 1) ?? 0;
            Assert.AreEqual(int.MaxValue, result); // Underflow
        }

        [TestMethod]
        public void TestSubtractionNegativeOverflow()
        {
            int result = _calculator?.Subtract(int.MaxValue, -1) ?? 0;
            Assert.AreEqual(int.MinValue, result); // Overflow
        }

        [TestMethod]
        public void TestSubtractionLargeNumbers()
        {
            int result = _calculator?.Subtract(200000, 100000) ?? 0;
            Assert.AreEqual(100000, result);
        }

        [TestMethod]
        public void TestSubtractionSmallNumbers()
        {
            int result = _calculator?.Subtract(2, 1) ?? 0;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestSubtractionMixedSigns()
        {
            int result = _calculator?.Subtract(-10, 5) ?? 0;
            Assert.AreEqual(-15, result);
        }

        [DataTestMethod]
        [DataRow(15, 5, 10)]
        [DataRow(25, 10, 15)]
        public void TestSubtractionTheory3(int a, int b, int expected)
        {
            int result = _calculator?.Subtract(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(100, 25, 75)]
        [DataRow(70, 30, 40)]
        public void TestSubtractionTheory4(int a, int b, int expected)
        {
            int result = _calculator?.Subtract(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(10, 10, 0)]
        [DataRow(20, 15, 5)]
        public void TestSubtractionTheory5(int a, int b, int expected)
        {
            int result = _calculator?.Subtract(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMultiplicationBasic()
        {
            int result = _calculator?.Multiply(5, 4) ?? 0;
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestMultiplicationWithZero()
        {
            int result = _calculator?.Multiply(0, 5) ?? 0;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMultiplicationNegativeNumbers()
        {
            int result = _calculator?.Multiply(-5, -4) ?? 0;
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestMultiplicationMixedSigns()
        {
            int result = _calculator?.Multiply(5, -4) ?? 0;
            Assert.AreEqual(-20, result);
        }

        [TestMethod]
        public void TestMultiplicationLargeNumbers()
        {
            int result = _calculator?.Multiply(10000, 20000) ?? 0;
            Assert.AreEqual(200000000, result);
        }

        [DataTestMethod]
        [DataRow(5, 5, 25)]
        [DataRow(10, 10, 100)]
        public void TestMultiplicationTheory1(int a, int b, int expected)
        {
            int result = _calculator?.Multiply(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(7, 3, 21)]
        [DataRow(6, 6, 36)]
        public void TestMultiplicationTheory2(int a, int b, int expected)
        {
            int result = _calculator?.Multiply(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(-5, 5, -25)]
        [DataRow(10, -5, -50)]
        public void TestMultiplicationTheory3(int a, int b, int expected)
        {
            int result = _calculator?.Multiply(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestDivisionBasic()
        {
            int result = _calculator?.Divide(20, 4) ?? 0;
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestDivisionNegativeNumbers()
        {
            int result = _calculator?.Divide(-20, -4) ?? 0;
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestDivisionMixedSigns()
        {
            int result = _calculator?.Divide(20, -4) ?? 0;
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void TestDivisionResultBelowOne()
        {
            int result = _calculator?.Divide(3, 4) ?? 0;
            Assert.AreEqual(0, result); // Integer division truncates
        }

        [DataTestMethod]
        [DataRow(25, 5, 5)]
        [DataRow(100, 20, 5)]
        public void TestDivisionTheory1(int a, int b, int expected)
        {
            int result = _calculator?.Divide(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(21, 3, 7)]
        [DataRow(64, 8, 8)]
        public void TestDivisionTheory2(int a, int b, int expected)
        {
            int result = _calculator?.Divide(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(-25, 5, -5)]
        [DataRow(50, -10, -5)]
        public void TestDivisionTheory3(int a, int b, int expected)
        {
            int result = _calculator?.Divide(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestModulusBasic()
        {
            int result = _calculator?.Modulus(10, 3) ?? 0;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestModulusNegativeNumbers()
        {
            int result = _calculator?.Modulus(-10, 3) ?? 0;
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestModulusMixedSigns()
        {
            int result = _calculator?.Modulus(10, -3) ?? 0;
            Assert.AreEqual(1, result);
        }

        [DataTestMethod]
        [DataRow(15, 4, 3)]
        [DataRow(17, 5, 2)]
        public void TestModulusTheory1(int a, int b, int expected)
        {
            int result = _calculator?.Modulus(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(20, 6, 2)]
        [DataRow(23, 7, 2)]
        public void TestModulusTheory2(int a, int b, int expected)
        {
            int result = _calculator?.Modulus(a, b) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestAdditionMaxInt()
        {
            int result = _calculator?.Add(int.MaxValue, 0) ?? 0;
            Assert.AreEqual(int.MaxValue, result);
        }

        [TestMethod]
        public void TestSubtractionMinInt()
        {
            int result = _calculator?.Subtract(int.MinValue, 0) ?? 0;
            Assert.AreEqual(int.MinValue, result);
        }

        [TestMethod]
        public void TestMultiplicationByOne()
        {
            int result = _calculator?.Multiply(int.MaxValue, 1) ?? 0;
            Assert.AreEqual(int.MaxValue, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionModulusByZero()
        {
            _calculator?.Modulus(5, 0);
        }

        [TestMethod]
        public void TestDivisionLargeBySmall()
        {
            int result = _calculator?.Divide(int.MaxValue, 1) ?? 0;
            Assert.AreEqual(int.MaxValue, result);
        }

        [TestMethod]
        public void TestMultiplicationMaxInt()
        {
            int result = _calculator?.Multiply(int.MaxValue, 2) ?? 0;
        }

        [TestMethod]
        public void TestSubtractionOverflow()
        {
            int result = _calculator?.Subtract(int.MinValue, 1) ?? 0;
        }

        [TestMethod]
        public void TestPowerBasic()
        {
            double result = _calculator?.Power(2, 3) ?? 0;
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestPowerByZero()
        {
            double result = _calculator?.Power(5, 0) ?? 0;
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestPowerOfZero()
        {
            double result = _calculator?.Power(0, 5) ?? 0;
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestPowerNegativeBase()
        {
            double result = _calculator?.Power(-2, 3) ?? 0;
            Assert.AreEqual(-8, result);
        }

        [TestMethod]
        public void TestPowerNegativeExponent()
        {
            double result = _calculator?.Power(2, -3) ?? 0;
            Assert.AreEqual(0.125, result, 0.00001);
        }

        [DataTestMethod]
        [DataRow(3, 3, 27)]
        [DataRow(4, 2, 16)]
        public void TestPowerTheory1(double baseVal, double exponent, double expected)
        {
            double result = _calculator?.Power(baseVal, exponent) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(5, -1, 0.2)]
        [DataRow(2, 4, 16)]
        public void TestPowerTheory2(double baseVal, double exponent, double expected)
        {
            double result = _calculator?.Power(baseVal, exponent) ?? 0;
            Assert.AreEqual(expected, result, 0.00001);
        }

        [TestMethod]
        public void TestSquareRootBasic()
        {
            double result = _calculator?.SquareRoot(4) ?? 0;
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestSquareRootOfZero()
        {
            double result = _calculator?.SquareRoot(0) ?? 0;
            Assert.AreEqual(0, result);
        }

        [DataTestMethod]
        [DataRow(9, 3)]
        [DataRow(16, 4)]
        public void TestSquareRootTheory1(double number, double expected)
        {
            double result = _calculator?.SquareRoot(number) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(25, 5)]
        [DataRow(81, 9)]
        public void TestSquareRootTheory2(double number, double expected)
        {
            double result = _calculator?.SquareRoot(number) ?? 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCubeRootBasic()
        {
            double result = _calculator?.CubeRoot(27) ?? 0;
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestLargeNumberAddition()
        {
            int result = _calculator?.Add(int.MaxValue - 10, 10) ?? 0;
            Assert.AreEqual(int.MaxValue, result);
        }

        [TestMethod]
        public void TestArithmeticOverflow()
        {
            int result = _calculator?.Add(int.MaxValue, 1) ?? 0;
        }
    }
}