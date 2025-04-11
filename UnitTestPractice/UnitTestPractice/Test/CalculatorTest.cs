using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPractice.Test
{
    public class CalculatorTest
    {

        public static void CalculatorTest_Addition_Returns10()
        {

            try
            {
                //Arrange
                int x = 5;
                int y = 5;
                Calculator calc = new Calculator();

                //Act
                int result = calc.add(x, y);

                //Assert
                if (result == 10)
                {
                    Console.WriteLine("PASSED : Addition");
                } else
                {
                    Console.WriteLine("FAILED : Addition");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        public static void CalculatorTest_Subtraction_Returns5()
        {

            try
            {
                //Arrange
                int x = 10;
                int y = 5;
                Calculator calc = new Calculator();

                //Act
                int result = calc.minus(x, y);

                //Assert
                if (result == 5)
                {
                    Console.WriteLine("PASSED : Subtraction");
                }
                else
                {
                    Console.WriteLine("FAILED : Subtraction");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static void CalculatorTest_Multiplication_Returns25()
        {

            try
            {
                //Arrange
                int x = 5;
                int y = 5;
                Calculator calc = new Calculator();

                //Act
                int result = calc.multiply(x, y);

                //Assert
                if (result == 25)
                {
                    Console.WriteLine("PASSED : Multiplication");
                }
                else
                {
                    Console.WriteLine("FAILED : Multiplication");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static void CalculatorTest_Division_Returns1()
        {

            try
            {
                //Arrange
                int x = 5;
                int y = 5;
                Calculator calc = new Calculator();

                //Act
                int result = calc.divide(x, y);

                //Assert
                if (result == 1)
                {
                    Console.WriteLine("PASSED : Division");
                }
                else
                {
                    Console.WriteLine("FAILED : Division");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

    }
}
