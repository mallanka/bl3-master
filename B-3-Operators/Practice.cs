using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            Console.Write("Insert the first number: ");
            Int32.TryParse(Console.ReadLine(), out var number1);
            Console.Write("Insert the second number: ");
            Int32.TryParse(Console.ReadLine(), out var number2);
            int result = number1 + number2;
            Console.WriteLine($"the result of addiction is {result}");
            Console.WriteLine("-".PadRight(50, '-'));
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.Write("Insert the first number: ");
            Int32.TryParse(Console.ReadLine(), out var number1);
            Console.Write("Insert the second number: ");
            Int32.TryParse(Console.ReadLine(), out var number2);
            int result = number1 + number2;
            Console.Write("Enter the result number: ");
            Int32.TryParse(Console.ReadLine(), out var userResult);
            Console.WriteLine(result == userResult ? "Correct" : "Wrong");
            Console.WriteLine("-".PadRight(50, '-'));
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.Write("Insert the first number: ");
            Int32.TryParse(Console.ReadLine(), out var number1);
            Console.Write("Insert the second number: ");
            Int32.TryParse(Console.ReadLine(), out var number2);
            int result = number1 + number2;
            int userResult;
            do
            {
                Console.Write("Enter the result number: ");
                Int32.TryParse(Console.ReadLine(), out userResult);
                Console.WriteLine(result == userResult ? "Correct" : "Wrong");
                if (result > userResult)
                    Console.WriteLine("The result is bigger");
                if (result < userResult)
                    Console.WriteLine("The result is lower");
            } while (result != userResult);

            Console.WriteLine("-".PadRight(50, '-'));
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            Console.Write("Insert the first number: ");
            Int32.TryParse(Console.ReadLine(), out var number1);
            Console.Write("Insert the second number: ");
            Int32.TryParse(Console.ReadLine(), out var number2);
            int result = 0;
            Console.Write("do you want to make addition or subtraction (insert the symbol): ");
            string operation = Console.ReadLine();
            if (operation == "+")
                result = number1 + number2;
            else if (operation == "-")
                result = number1 - number2;
            else
                Console.WriteLine("you broke the program");
            if (operation == "+" || operation == "-")
            {
                int userResult;
                Console.Write("Enter the result number: ");
                Int32.TryParse(Console.ReadLine(), out userResult);
                Console.WriteLine(result == userResult ? "Correct" : "Wrong");
                if (result > userResult)
                    Console.WriteLine("The result is bigger");
                if (result < userResult)
                    Console.WriteLine("The result is lower");
            }

            Console.WriteLine("-".PadRight(50, '-'));
        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            Console.Write("Insert the first number: ");
            Int32.TryParse(Console.ReadLine(), out var number1);
            Console.Write("Insert the second number: ");
            Int32.TryParse(Console.ReadLine(), out var number2);
            int result = 0;
            Console.Write("do you want to make addition or subtraction (insert the symbol): ");
            string operation = Console.ReadLine();
            if (operation == "+")
                result = number1 + number2;
            else if (operation == "-")
                result = number1 - number2;
            else
                Console.WriteLine("you broke the program");
            if (operation == "+" || operation == "-")
            {
                int userResult;
                int triesCount = 1;
                do
                {
                    Console.Write("Enter the result number: ");
                    string inputNumber = Console.ReadLine();
                    Int32.TryParse(inputNumber, out userResult);
                    Console.WriteLine(result == userResult ? "Correct" : "Wrong");
                    if (result > userResult)
                        Console.WriteLine("The result is bigger");
                    if (result < userResult)
                        Console.WriteLine("The result is lower");
                    triesCount++;
                } while (result != userResult && triesCount < 4);
            }

            Console.WriteLine("-".PadRight(50, '-'));
        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            Console.Write("Insert the first number: ");
            Int32.TryParse(Console.ReadLine(), out var number1);
            Console.Write("Insert the second number: ");
            Int32.TryParse(Console.ReadLine(), out var number2);
            Console.Write("Insert the third number: ");
            Int32.TryParse(Console.ReadLine(), out var number3);
            Console.Write("Insert the fourth number: ");
            Int32.TryParse(Console.ReadLine(), out var number4);
            Console.Write("Insert the fifth number: ");
            Int32.TryParse(Console.ReadLine(), out var number5);
            int result = 0;
            Console.Write("do you want to make addition or subtraction (insert the symbol): ");
            string operation = Console.ReadLine();
            if (operation == "+")
                result = number1 + number2 + number3 + number4 + number5;
            else if (operation == "-")
                result = number1 - number2 - number3 - number4 - number5;
            else
                Console.WriteLine("you broke the program");
            if (operation == "+" || operation == "-")
            {
                int userResult;
                int triesCount = 1;
                do
                {
                    Console.Write("Enter the result number: ");
                    string inputNumber = Console.ReadLine();
                    Int32.TryParse(inputNumber, out userResult);
                    Console.WriteLine(result == userResult ? "Correct" : "Wrong");
                    if (result > userResult)
                        Console.WriteLine("The result is bigger");
                    if (result < userResult)
                        Console.WriteLine("The result is lower");
                    triesCount++;
                } while (result != userResult && triesCount < 4);
            }

            Console.WriteLine("-".PadRight(50, '-'));
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            Console.Write("Insert the first number: ");
            Int32.TryParse(Console.ReadLine(), out var number1);
            Console.Write("Insert the second number: ");
            Int32.TryParse(Console.ReadLine(), out var number2);
            Console.Write("Insert the third number: ");
            Int32.TryParse(Console.ReadLine(), out var number3);
            Console.Write("Insert the fourth number: ");
            Int32.TryParse(Console.ReadLine(), out var number4);
            Console.Write("Insert the fifth number: ");
            Int32.TryParse(Console.ReadLine(), out var number5);
            int result = 0;
            Console.Write("do you want to make addition or subtraction (insert the symbol): ");
            string operation = Console.ReadLine();
            if (operation == "+")
                result = number1 + number2 + number3 + number4 + number5;
            else if (operation == "-")
                result = number1 - number2 - number3 - number4 - number5;
            else
                Console.WriteLine("you broke the program");
            if (operation == "+" || operation == "-")
            {
                int userResult;
                int triesCount = 1;
                do
                {
                    Console.Write("Enter the result number: ");
                    string inputNumber = Console.ReadLine();
                    Int32.TryParse(inputNumber, out userResult);
                    Console.WriteLine(result == userResult ? "Correct" : "Wrong");
                    if (result > userResult)
                        Console.WriteLine("The result is bigger");
                    if (result < userResult)
                        Console.WriteLine("The result is lower");
                    triesCount++;
                } while (result != userResult && triesCount < 4);
            }

            Console.WriteLine("-".PadRight(50, '-'));
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            Console.Write("Enter the radius of circle: ");
            double.TryParse(Console.ReadLine(), out var radius);
            Console.WriteLine("the square of circle are equal " + (Math.Pow(radius, 2) * Math.PI));
            Console.WriteLine("-".PadRight(50, '-'));
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            Console.Write("Enter the loan amount: ");
            double.TryParse(Console.ReadLine(), out var loanAmount);
            Console.Write("Enter the rate value: ");
            double.TryParse(Console.ReadLine(), out var rateValue);
            Console.WriteLine("payment for a months:");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} month: " + (loanAmount * (1 + rateValue / 100) / 12));
            }

            Console.WriteLine("the total amount of payments are equal: " + (loanAmount * (1 + rateValue / 100)));
            Console.WriteLine("-".PadRight(50, '-'));
        }
    }
}
