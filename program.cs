/*
 * Author: Gabriela Benavides
 * Coures: Comp-003
 * Purpose: Lecture activity for variables, type system, Math, and Consloe properties
 * Reference;The C# Player's Guids (4e) by RB Whitaker
 * */

using System.Diagnostics;

namespace COMP003A.LectureActivity2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /* working with variables */
            // the following code show all three primary variable-ralated activites:
            string username; // declariing a verialbe (1 of 3)
            Console.WriteLine("What is your name?"); // request for user input
            username = Console.ReadLine(); // assiging a vales to a varialbe (2 of 3)
            Console.WriteLine("Hi " + username); // reatieving its current value (3 of 3)

            // another example of the three primary variable related activities (declaring, assigning, and retriveving)
            string favoriteColor;
            Console.WriteLine("what your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favoriteColor);

            /* working with variable integers */
            int score; // declare a new variable with a date type int
                       // score = "Generic User"; // will fail to compile because you are assignin a string value to an intaeger variable
                       // score = "0"; // will still faikl to compile because the "0" is still assig as a string - en cllsed in the double quotes
            score = 0; // works
            score = 4; // you can also reassign values to the variable as long as they are within scope and not constant
            score = 11;
            score = -1564;


            /* reading from a variable dose not change it */
            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The current value of a: " + a);
            Console.WriteLine(" The current value of b: " + b);

            b = a;
            a = -3;
            Console.WriteLine("The new value of a: " + a);
            Console.WriteLine("The new value of b: " + b);

            /* variables are case-sensitive */
            // the variables below are different depite having similar names
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("******************************************");
            /*
             *  types of variables and values matter in C#. they are not interchangealbe.
             *  there are eight integer types for storing integres of differing sizes ranges: int, short, long, byte, sbyte, unit, ushort, and ulong.
             *  the char type stores signle charctres.
             *  the string type stores longer text.
             *  there are three types for storing real numbers: flooat, double, and decimal.
             *  the bool type stores truth vales (true and fales) used in logic.
             *  there types are the builing blocks of a much larger type system.
             *  using var for a variable's type tells the compiler to infer its type from the surrounding code, so you don not have to type it out. (But it still has a specific type.)
             *  the system.Convert class is a useful class to convert from one type top another.
             */

            /* declaring and using variables with intager types */
            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte:" + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte: " + aSingleByte);

            short aNumber = 5039;
            Console.WriteLine("aNumber: " + aNumber);
            aNumber = 4354;
            Console.WriteLine("aNumber: " + aNumber);

            long aVeryBignumber = 395904282569;
            Console.WriteLine("aVaryBigNumber: " + aVeryBignumber);
            aVeryBignumber = 13;
            Console.WriteLine("aVeryBigNumber: " + aVeryBignumber);

            int anInteger = 2147483647;

            /* declaring,using, and concatenating characters ans strings */
            char aLetter = 'A'; // character values are strings */
            string message = " Hello World! "; // string values are enclosed in double quotes

            Console.WriteLine(" Concatenation using + : " + aLetter + " " + message); // use the plue (+) sign in  between charectres/strings to concatenate
            Console.WriteLine($"Concatenation using string interpolation : {aLetter} {message}"); // use string interpolation with a dollar-sign ($) before the opening double-quote and enclosing variables with curly braces ({variableName})

            /* floating-point types*/
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"value of number1: {number1}");
            Console.WriteLine($"Value of number2: {number2}");
            Console.WriteLine($"Value of number3: {number3}");

            /* scientific notation */
            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogadrosNumber: {avogadrosNumber}");

            /* bool type */
            bool itworked = true;
            Console.WriteLine($"Value of itWorked: {itworked}");
            itworked = false;
            Console.WriteLine($"New value of itWorked: {itworked}");

            /* convert */
            string inputAgeString;
            int inputAge;
            int currentYear = 2023;
            Console.WriteLine($"Enter age in {currentYear}: ");
            inputAgeString = Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgeString);
            Console.WriteLine($"Your age is {inputAge} ");

            Console.WriteLine("********************************************");
            /*
             * math operations
             * addition: +
             * Subtraction: -
             * Multipication: *
             * division: /
             * Modulo: % (remainder)
            */
            int addition = 2 + 3;
            int subtractraction = 5 - 2;
            int multiplication = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition: {addition} ");
            Console.WriteLine($"Value of subtraction: {subtractraction} ");
            Console.WriteLine($"Value of multiplicattion: {multiplication} ");
            Console.WriteLine($"Value of division: {division} ");
            Console.WriteLine($"Value of modulo: {modulo} ");

            /*
             *  arithemetic, compound expressions and order of operations
             *  Multiplication and division are done first, left to right
             *  Addition and subtraction are done last, left to right
             *  Reference: https://csharpplayersguide.com/articles/operators-table
             */

            int arithmeticl; // declaring the variable arithmeticl.
            arithmeticl = 9 - 2; // assigning a value to aritheticl, using some math
            Console.WriteLine($"Value of arithmticl: {arithmeticl} ");
            arithmeticl = 3 + 3; // another assignment.
            Console.WriteLine($"New value of arithmeeticl: {arithmeticl} ");
            int arithmetic2 = 3 + 1; // declaring arithmetic2 and assigning a value to arithmetic2 all at ones.
            Console.WriteLine($"Value of arithmetic2: {arithmetic2} ");
            arithmetic2 = 1 + 2; // assigning a second value to arithmetic2.
            Console.WriteLine($"New value of arithmetic2:{arithmetic2} ");

            // use multiple sets of perentheses to group operations
            int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"Value of resuit: {result} ");

            /* compound assignmet operator */
            int compoundAssignmetOperator = 0;
            compoundAssignmetOperator += 5;   // The equivalent of compoundAssignmetOperator = compoundAssignmetOperator + 5; (a is 5 after this lines runs)
            compoundAssignmetOperator -= 2;  // The equivalent of compoundAssignmentOperator = compoundAssignmentOpertor - 2; (a is 3 after this lines runs)
            compoundAssignmetOperator *= 4; // The equivalent of compoundAssignmentOpertor = compoundAssignmentOpertor * 4; (a is 12 after this lines runs)
            compoundAssignmetOperator /= 2; // The equivalent of compoundAssignmetOpertor = compoundAssignmentOpertor / 2; (a is 6 after this lines runs)
            compoundAssignmetOperator %= 2; // The equivalent of compoundAssignmetOpertor = compoundAssignmentOpertor % 2; (a is 0 after this lines runs)

            /* increment and decrement opertors */
            int incrementDecrementOpertors = 0;
            incrementDecrementOpertors++; // The equivalent of incrementDecrementOpertors += 1; or incrementDecrementOpertors = incrementDecrementOpertors =1;
            incrementDecrementOpertors--; // The equivalent ifincrementDecrementOpertors -= 1; or incrementDecrementOpertors = incrementDecrementOpertors = -1;

            Console.WriteLine("*******************************************");
            /* console 2.0 */
            Console.WriteLine("What is your name, human? "); // notice the space at the end.
            string useName = Console.ReadLine() ; // reads the entire space at the end.
            // reault: What is your name, human? gabriela //

            Console.WriteLine("Press any key when your're ready to begin.");
            Console.ReadKey(); // reads a keystorke //

            Console.BackgroundColor = ConsoleColor.Yellow; // changes the console backgound to yellow//
            Console.ForegroundColor = ConsoleColor.Black; // changes the consloe text tp black //
            Console.Title = "Hello world!"; // changes the console title //

            Console.Beep(440, 1000); // computer beeps //             


        }
    }
}   
        
    
