using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        // public static string ReverseStringHard(string quote)
        // {
        //     throw new NotImplementedException();
        // }

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")

                    public static string SayHello(string name)
                    {
                        return ("Hello " + name + "!");
                    } 
        
        // 2. Create a method called Sum that accepts two integers and returns their sum.
                 public static int Sum(int a, int b)
                    {
                        return (a + b);
                    } 
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
                public static int Divide(int a, int b)
                    {
                        return (a / b);
                    } 
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
                public static bool CanOpenCheckingAccount(int age)
                    {
                        if(age >= 18){return true;}

                        return false;
                    } 
        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
                public static string GetFirstName(string fullName)
                    {
                        var names = fullName.Split(' ');
                        string firstName = names[0];
                        string lastName = names[1];

                        return firstName;
                    } 

        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
                //  public static string ReverseStringHard(string stringReversed)
                //     {
                //          int n = stringReversed.Length;
                //         Console.WriteLine("This is the string", stringReversed);
                //         Console.WriteLine("This is the length", n);
                //         // // Swap character starting from two
                //         // // corners
                //         // for (int i = 0; i < n / 2; i++)
                //         //     swap(stringReversed[i], stringReversed[n - i - 1]);

                //         return stringReversed;
                //     }
        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
                    public static string ReverseStringEasy(string s)
                     {
                                char[] charArray = s.ToCharArray();
                                Array.Reverse( charArray );
                                return new string( charArray );
                     } 
        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */

                public static string PrintTimesTable( int number)
                {
                    var input = number;
                    var times = 10;
                    int n = 1;
                    var multiples = "";

                    while (n <= times)
                    {
                    multiples += $"{input} * {n} = {input * n}\r\n";         
                    n++;
                    }
         
                    return multiples.Trim();
                }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
                public static double ConvertKelvinToFahrenheit( double tempK)
                {
                    // var tempF = (float)((tempK - 273.15) * 9/5 + 32);
                    var tempCalc = ((tempK - 273.15) * 9/5 + 32);
                    var tempF = Math.Round(tempCalc, 2);
        
                    return tempF;
                }

        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
            public static double GetAverageHard( int[] integers)
                {
                   int arrLength = integers.Length;
                   int sum = integers.Sum();

                   double average = ((double) sum) / arrLength;

                   return average;
                }
        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
                public static double GetAverageEasy( int[] integers)
                {
                   return integers.Average();
                }
        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

                public static string DrawTriangle( int number, int width)
                {
                    
                   var triangle = "";
                   for(int i=width; i >=1; i--){

                       for (int j=i; j>0; j--){
                           triangle += number;
                       };

                    triangle += "\r\n";

                   };
                   return triangle.Trim();
                }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
                public static string GetMilesPerHour( double distance, int hours, int minutes, int seconds)
                {

                    double minuteConversion = (double)minutes / 60;
                    var secondConversion = (double)seconds / 3600;
                    var timeInHrs = (hours + minuteConversion + secondConversion);

                    var speed= Math.Ceiling(distance/timeInHrs);
                    var MPH = $"{speed}MPH";

                    return MPH;
                }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
                public static bool IsVowel(char letter)
                {
                    // Console.WriteLine(letter);
                    var vowels = "aeiou";
                    if( letter == vowels[0]){
                        return true;
                    }
                    if( letter == vowels[1]){
                        return true;
                    }if( letter == vowels[2]){
                        return true;
                    }if( letter == vowels[3]){
                        return true;
                    }if( letter == vowels[4]){
                        return true;
                    }
                    else{ return false;}

                }

        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
            public static bool IsConsonant(char letter)
                    {
                        // Console.WriteLine(letter);
                        var vowels = "aeiou";
                        if( letter == vowels[0]){
                            return false;
                        }
                        if( letter == vowels[1]){
                            return false;
                        }if( letter == vowels[2]){
                            return false;
                        }if( letter == vowels[3]){
                            return false;
                        }if( letter == vowels[4]){
                            return false;
                        }
                        else{ return true;}

                    }
        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
                    public static int CollatzConjecture(int n)
                    {
                        var steps = 0;

                        while (n != 1)
                        {

                            // If n is odd
                            if ((n & 1) == 1){
                                n = 3 * n + 1;
                                steps += 1;
                            }
                            // If even
                            else{                                
                                n = n / 2;
                                steps += 1;
                            }
                        };
                    return steps;
                                    
                }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
                public static DateTime[] GetNext7Days(DateTime day)
                    {

                      DateTime today = new DateTime(2016,8,22);
                        Console.WriteLine(today);

                            DateTime[] dateTimes = new DateTime[]
                        {
                            today,
                            // new DateTime(longToday.AddDays(1)),
                            new DateTime(2016, 8, 23),
                            new DateTime(2016, 8, 24),
                            new DateTime(2016, 8, 25),
                            new DateTime(2016, 8, 26),
                            new DateTime(2016, 8, 27),
                            new DateTime(2016, 8, 28)
                        };

                        Console.WriteLine("[{0}]", string.Join(", ", dateTimes), dateTimes);
                        // Console.WriteLine(dateTimes[5]);

                    return dateTimes;
                                    
                    }

        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
            public static bool IsInLeapYear(int year)
            {
                
                if(year == 1800| year == 1900|year == 2000){
                    var isleap = year%400;
                    if(isleap == 0){
                        return true;
                    }else{return false;}

                }
                if(year%4 == 0){
                    return true;
                }

            return false;

            }
        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
            public static double MortgageCalculator(decimal loanBalance, double interestRate, int LoanTerm, int PaymentPeriod)
            {
                double years = (double)LoanTerm;
                double principal = (double)loanBalance;
                double rate = (double)interestRate / 100;

                Console.WriteLine("\nBased on these values entered:");
                Console.WriteLine(" - Number of years .... {0}", years);
                Console.WriteLine(" - Principal amount ... {0:c}", principal);
                Console.WriteLine(" - Interest rate ...... {0:p}", rate);

                double monthlyRate = rate / 12;
                double payments = 12 * years;

                double result =
                    principal *
                    (monthlyRate * Math.Pow(1 + monthlyRate, payments)) /
                    (Math.Pow(1 + monthlyRate, payments) - 1);

                Console.WriteLine("\nYour monthly payment will be: {0:c}", result);
                Console.WriteLine(Math.Round((double)result, 2));
                return Math.Round((double)result, 2);

            }


        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

         public static string DuckGoose(int num)
            {
                string duckGooseString = "";

               for (int i = 1; i <= num; i++)  
                {  
                    if (i % 3 == 0 && i % 5 == 0)  
                    {  
                        duckGooseString += "DuckGoose\r\n";
                    }  
                    else if (i % 3 == 0)  
                    {  
                    duckGooseString += "Duck\r\n";  
                    }  
                    else if (i % 5 == 0)  
                    {  
                    duckGooseString += "Goose\r\n";  
                    }  
                    else  
                    {  
                        duckGooseString += i + "\r\n"; 
                    }  
                }  

               return duckGooseString.Trim();

            }

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}