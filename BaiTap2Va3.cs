// Cao Nguyen Lan Anh
// Bai tap buoi 2 va buoi 3
using System;
using System.Globalization;

namespace BaiTap2Va3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai tap 2. Hang va bien trong C#
            // //Bai 1.
            // Console.WriteLine("Enter two integers separated by space:");

            // // Read the input line
            // string input = Console.ReadLine() ?? "0 0";

            // // Split the input by space and convert each part to an integer
            // string[] inputs = input.Split(' ');
            // int a = int.Parse(inputs[0]);
            // int b = int.Parse(inputs[1]);

            // // Output the numbers
            // Console.WriteLine($"You entered: {a} and {b}");

            // //Calculation
            // int sum = a + b;
            // int minus = a - b;
            // int mul = a * b;
            // float div = (float)a / b;

            // //Print results
            // Console.WriteLine($"Sum: a + b = {sum}");
            // Console.WriteLine($"Minus: a - b = {minus}");
            // Console.WriteLine($"Multiple: a * b = {mul} ");
            // Console.WriteLine($"Divine: a / b = {div}");
            // Console.ReadKey();


            //------------------------------------------------------------------

            // //Bai 2
            // Console.WriteLine("Enter two sides of a rectangle (seperated by space): ");

            // // Read the input line
            // string input = Console.ReadLine() ?? "0 0";

            // // Split the input by space and convert each part to an integer
            // string[] inputs = input.Split(' ');
            // int a = int.Parse(inputs[0]);
            // int b = int.Parse(inputs[1]);

            // // Output the numbers
            // Console.WriteLine($"Rectangle's data: {a} and {b}");

            // //Calculation
            // int S = a * b;
            // int C = (a + b) * 2;

            // //Print results
            // Console.WriteLine($"Area: a * b = {S}");
            // Console.WriteLine($"Circumference: (a + b) * 2 = {C}");
            // Console.ReadKey();
            
            //------------------------------------------------------------------

            // //Bai 3
            // Console.WriteLine("Enter the radius of the circle: ");

            // // Read the input line
            // int radius = int.Parse(Console.ReadLine() ?? "0");

            // // Output the radius
            // Console.WriteLine($"Circle's radius: {radius}" );

            // //Calculation
            // double S = radius * radius * Math.PI;
            // double C = radius * 2 * Math.PI;

            // //Print results
            // Console.WriteLine($"Area: radius * 3.14 = {S}");
            // Console.WriteLine($"Circumference: radius * 2 * 3.14 = {C}");
            // Console.ReadKey();
            
            //------------------------------------------------------------------


            // Bai 4
            // Console.WriteLine("Enter student's name: ");

            // // Read the name
            // string name = Console.ReadLine() ?? " ";

            // Console.WriteLine("Enter student's class: ");

            // //Read the class
            // string studentClass = Console.ReadLine() ?? " ";

            // Console.WriteLine("Enter student's GPA in first term and second term (seperated by space): ");

            // // Split the input by space and convert each part to a float
            // string input = Console.ReadLine() ?? "0.0 0.0";
            // string[] inputs = input.Split(' ');
            // float firstTerm = float.Parse(inputs[0]);
            // float secondTerm = float.Parse(inputs[1]);

            // // Output the information
            // Console.WriteLine($"Student's name: {name}, class: {studentClass}, GPA in first and second term: {firstTerm} {secondTerm}");

            // //Calculation
            // float wholeYearGPA = (firstTerm + secondTerm * 2) / 3;

            // //Print results
            // Console.WriteLine($"Whole year GPA: {wholeYearGPA}");
            // Console.ReadKey();
            
            //------------------------------------------------------------------


            // // Bai 5
            // Console.WriteLine("Enter fisrt employee's name: ");

            // // Read the name
            // string name1 = Console.ReadLine() ?? " ";
            
            // //Read the rest information
            // Console.WriteLine("Enter the rest information (gender, date of birth, salary cofficient, base salary, working year): ");
            // string input = Console.ReadLine() ?? " ";
            // string[] inputs = input.Split(' ');
            // string gender1 = inputs[0];
            // string dob1 = inputs[1];
            // float salaryCoefficient1 = float.Parse(inputs[2]);
            // double baseSalary1 = double.Parse(inputs[3]);
            // int workingYear1 = int.Parse(inputs[4]);
            
            // double allowance1 = (workingYear1 > 5) ? baseSalary1 * 0.5 : 0.0;

            // Console.WriteLine("Enter second employee's name: ");

            // // Read the name
            // string name2 = Console.ReadLine() ?? " ";
            
            // //Read the rest information
            // Console.WriteLine("Enter the rest information (gender, date of birth, salary cofficient, base salary, working year): ");
            // input = Console.ReadLine() ?? " ";
            // inputs = input.Split(' ');
            // string gender2 = inputs[0];
            // string dob2 = inputs[1];
            // float salaryCoefficient2 = float.Parse(inputs[2]);
            // double baseSalary2 = double.Parse(inputs[3]);
            // int workingYear2 = int.Parse(inputs[4]);
            
            // double allowance2 = (workingYear2 > 5) ? baseSalary2 * 0.5 : 0.0;

            // // Output the information
            // Console.WriteLine($"First employee's name: {name1}, gender: {gender1}, date of birth: {dob1}, salary cofficient: {salaryCoefficient1}, base salary: {baseSalary1}, working year: {workingYear1}, Allowance: {allowance1}");
            // Console.WriteLine($"Second employee's name: {name2}, gender: {gender2}, date of birth: {dob2}, salary cofficient: {salaryCoefficient2}, base salary: {baseSalary2}, working year: {workingYear2}, Allowance: {allowance2}");

            // Console.ReadKey();
            
            //------------------------------------------------------------------


            // //Bai 6

            // //Read the date
            // Console.WriteLine("Enter the desired day: ");
            // int day = int.Parse(Console.ReadLine() ?? "0");

            // Console.WriteLine("Enter the desired month: ");
            // int month = int.Parse(Console.ReadLine() ?? "0");

            // Console.WriteLine("Enter the desired year: ");
            // int year = int.Parse(Console.ReadLine() ?? "0");


            // //Create a DateTime object
            // DateTime currentDate = new DateTime(year, month, day);

            // //Calculation
            // DateTime yesterday = currentDate.AddDays(-1);
            // DateTime tomorrow = currentDate.AddDays(1);

            // // Output the result
            // Console.WriteLine("-------------------------------->");
            // Console.WriteLine("Yesterday: {0:dd/MM/yyyy}", yesterday);
            // Console.WriteLine("Today: {0:dd/MM/yyyy}", currentDate);
            // Console.WriteLine("Tomorrow: {0:dd/MM/yyyy}", tomorrow);
            // Console.WriteLine("<--------------------------------");

            // Console.ReadKey();

            // **************************************************************
            // Bai 3. Cau truc dieu khien

            // //Bai 1
            // Console.WriteLine("Enter the number: ");

            // // Read the input line
            // int number = int.Parse(Console.ReadLine() ?? "0");

            // // Output the number
            // Console.WriteLine($"Number: {number}" );

            // // Output the result
            // if (number % 3 == 0) Console.WriteLine($"Number {number} is divisible by 3");
            // else Console.WriteLine($"Number {number} is not divisible by 3");

            // Console.ReadKey();
            
            //------------------------------------------------------------------

            // //Bai 2
            // Console.WriteLine("Enter the number: ");

            // // Read the input line
            // int number = int.Parse(Console.ReadLine() ?? "0");

            // // Output the number
            // Console.WriteLine($"Number: {number}" );

            // // Output the result
            // for(int i = 1; i <= number; i++) {
            //     for (int j = 1; j <= 10; j++) {
            //         Console.WriteLine($"{i} x {j} = {i * j}" );
            //     }
            //     Console.WriteLine("-------------------");
            // }

            // Console.ReadKey();
            
            //------------------------------------------------------------------

            // // Bai 3
            // Console.WriteLine("Enter the number: ");

            // // Read the input line
            // int number = int.Parse(Console.ReadLine() ?? "0");

            // // Output the number
            // Console.WriteLine($"Number: {number}" );

            // int sum = 0;
            // // Output the result
            // for(int i = 1; i <= number; i++) {
            //     int factorial = 1;
            //     for (int j = 1; j <= i; j++) {
            //         factorial *= j;
            //     }
            //     sum += factorial;
            // }

            // // Output the result
            // Console.WriteLine($"The sum of factorials from 1 to {number}: {sum}");

            // Console.ReadKey();
            
            //------------------------------------------------------------------

            // // Bai 4
            // Console.WriteLine("Enter the number: ");

            // // Read the input line
            // int number = int.Parse(Console.ReadLine() ?? "0");

            // // Output the number
            // Console.WriteLine($"Number: {number}" );

            // // Calculate 
            // double sqrt = Math.Sqrt(number);

            // // Output the result
            // if (sqrt == (int)sqrt) Console.WriteLine($"Number {number} is square number");
            // else Console.WriteLine($"Number {number} is not square number");

            // Console.ReadKey();
            
            //------------------------------------------------------------------
            
            // Bai 5
            // Console.Write("Enter the month (1-12): ");
            // int month = int.Parse(Console.ReadLine() ?? "0");

            // //we need the year in case of leap year => February has 29 days
            // Console.Write("Enter the year: ");
            // int year = int.Parse(Console.ReadLine() ?? "0");

            // // Get the number of days in the given month and year
            // int daysInMonth = DateTime.DaysInMonth(year, month);

            // Console.WriteLine($"Month {month} in {year} has {daysInMonth} days.");

            // Console.ReadKey();

            //------------------------------------------------------------------
            
            // Bai 6
            // Console.WriteLine("Enter the number: ");

            // // Read the input line
            // int number = int.Parse(Console.ReadLine() ?? "0");

            // // Output the number
            // Console.WriteLine($"Number: {number}" );

            // double sum = 0;
            // // Output the result
            // for(int i = 1; i <= number; i++) {
            //     sum += Math.Pow(i, i);
            // }

            // // Output the result
            // Console.WriteLine($"The sum of powers from 1 to {number}: {sum}");

            // Console.ReadKey();

            //------------------------------------------------------------------

            // // Bai 7
            // Console.WriteLine("Enter the number: ");

            // // Read the input line
            // int number = int.Parse(Console.ReadLine() ?? "0");

            // // Output the number
            // Console.WriteLine($"Number: {number}" );

            // // Calculation
            // int sum = 0;
            // for(int i = 0; i <= number; i++) {
            //     if (i % 2 != 0) sum+= i;
            // }

            // // Output the result
            // Console.WriteLine($"The sum of odd intergers from 1 to {number}: {sum}");

            // Console.ReadKey();
            
            //------------------------------------------------------------------

            // // Bai 8
            // Console.WriteLine("Enter the number: ");

            // // Read the input line
            // int number = int.Parse(Console.ReadLine() ?? "0");

            // // Output the number
            // if(number <= 1) {
            //     Console.WriteLine($"Number {number} is not prime number");
            //     return;
            // }
            // else Console.WriteLine($"Number: {number}" );

            // // Calculation
            // int count = 0;
            // for(int i = 1; i <= number; i++) {
            //     if(number % i == 0) count++;
            // }

            // // Output the result
            // if (count == 2) Console.WriteLine($"Number {number} is prime number");
            // else Console.WriteLine($"Number {number} is not prime number");

            // Console.ReadKey();
            
            //------------------------------------------------------------------

            // Bai 9
            // Console.WriteLine("Enter the number: ");

            // // Read the input line
            // int number = int.Parse(Console.ReadLine() ?? "0");

            // // Output the number
            // Console.WriteLine($"Number: {number}" );

            // // Output the result
            // for (int i = 1; i <= number; i++) {
            //     for(int j = 1; j <= i; j++) {
            //         Console.Write("*");
            //     }
            //     Console.WriteLine();
            // }

            // Console.ReadKey();
            
            //------------------------------------------------------------------

            // Bai 10
            Console.Write("Enter an interger: ");

            int number = int.Parse(Console.ReadLine() ?? "0");

            if (number <= 0) {
                Console.WriteLine("Please enter a positive interger");
                return;
            }

            //Output result
            Console.WriteLine($"The Fibonacci series with {number} elements: ");
            
            int a = 0, b = 1;

            for (int i = 0; i < number; i++)
            {
                Console.Write(a + " ");

                // Calculate the next Fibonacci number
                int next = a + b;
                a = b;
                b = next;
            }

            Console.ReadKey();
        }
    }
}