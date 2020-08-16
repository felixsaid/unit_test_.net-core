using UnitTestingMath;
using Xunit;

namespace XUnitTestMath
{
    public class MathOperationTest
    {
        [Fact]
        public void Test_Add_Numbers()
        {
            var number_one = 5;
            var number_two = 4;
            var expected_value = 9;


            //Act

            var sum = MathOperation.AddNumbers(number_one, number_two);

            //Assert

            Assert.Equal(expected_value, sum, 1);
        }

        [Fact]
        public void Test_Subtract_Number()
        {
            var number_one = 4;
            var number_two = 3;
            var expected_value = 1;

            //Act

            var sub = MathOperation.SubtractNumbers(number_one, number_two);

            //Assert

            Assert.Equal(expected_value, sub, 1);
        }

        [Fact]
        public void Test_Multiply_Number()
        {
            var number_one = 3;
            var number_two = 2;
            var expected_value = 6;

            //Act

            var mult = MathOperation.MultiplyNumbers(number_one, number_two);

            //Assert

            Assert.Equal(expected_value, mult, 2);
        }

        [Fact]
        public void Test_Divide_Number()
        {
            var number_one = 4;
            var number_two = 2;
            var expected_values = 2;

            //Act

            var div = MathOperation.DivideNumbers(number_one, number_two);

            //Assert

            Assert.Equal(expected_values, div, 2);
        }
    }
}
