using System;

namespace MiniApps
{
    class MenuSystem
    {
        public static void Main(string[] args)
        {   
            bool menu = true;
            bool counting = false;
            bool rootCalc = false;

            while(menu == true) 
            {
                Console.Clear();
                Console.WriteLine("MiniApps - Thomas Heenan");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("1. Keep Counting");
                Console.WriteLine("2. Square Root Calc.");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("> ");

                int input = Int32.Parse(Console.ReadLine());

                switch(input) {
                    case 1: counting = true; menu = false; Console.Clear(); break;
                    case 2: rootCalc = true; menu = false; Console.Clear(); break;
                    default: Console.Clear(); Console.Write("Please Make a Valid Selection!"); 
                    System.Threading.Thread.Sleep(1000); continue;
                }

            while (counting == true) //1. KeepCounting
            {

                // Variable declaration
                int[] addends = { 0, 0 };
                int result = 0;
                bool availRes = false;
                int question = 0;

                /* While Loop which will cycle through questions, 
                with the initial addend being the result of the last */
                while (question < 10)
                {
                    /* Generates a random number twice according to the loop, 
                    each time appending an array which stores question values */
                    for (int j = 0; j <= 1; j++)
                    {
                        Random rnd = new Random();
                        int num = rnd.Next(100);
                        addends[j] = num;
                    }

                    /* This checks if a result has already been stored
                    from the last question and modifies the array if necessary */
                    if (availRes == true)
                    {
                        addends[0] = result;
                    }

                    Random rnd1 = new Random();
                    int op = rnd1.Next(0, 2);

                    // A boolean if statement determines addition or subtraciton
                    if (op == 0)
                    {
                        result = addends[0] + addends[1];
                        Console.Write("{0} + {1} = ", addends[0], addends[1]);
                    }
                    else
                    {
                        result = addends[0] - addends[1];
                        Console.Write("{0} - {1} = ", addends[0], addends[1]);
                    }

                    /* The 'available result' variable is changed so we may
                    use the result in the next question */
                    availRes = true;
                    int answer = Int32.Parse(Console.ReadLine());

                    /* If statement prints confirmation of answer
                    and increments the question counter based on the result*/
                    if (answer == result)
                    {
                        Console.WriteLine("correct!");
                        question++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Try again");
                        question = 0;
                    }

                }

                counting = false;
                menu = true;
                Console.WriteLine("Finish!");
                Console.ReadLine();
                menu = true;
                break;

            }

            while (rootCalc == true) //2. Square Root Calc.
            {
                int inputSqrt = 0;
                int precision = 0;
                bool paramMenu = true;

                while(paramMenu) {
                    Console.Write("Enter a Positive Integer: ");
                    inputSqrt = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.Write("Enter the decimal precision of the result: ");
                    precision = Int32.Parse(Console.ReadLine());
                    if(precision > 6 || precision < 0) {
                        Console.Clear();
                        Console.WriteLine("Please enter a valid precision!");
                        System.Threading.Thread.Sleep(1000);
                        continue;
                    } else {
                        paramMenu = false;
                    }
                }

                double upper = inputSqrt;
                double lower = 0;

                double avrg = (upper + lower) / 2;

                double avrgSqr = avrg * avrg;

                Console.WriteLine(avrgSqr);
            
                while(avrgSqr != inputSqrt) {
                    if (avrgSqr > inputSqrt) {
                        upper = avrg;
                    } else if (avrg < inputSqrt) {
                        lower = avrg;
                    }

                    avrg = (upper + lower) / 2;
                    avrgSqr = avrg * avrg;
                    avrgSqr = Math.Round(avrgSqr, precision);

                    Console.WriteLine(Math.Round(avrg, precision));

                }

                avrg = Math.Round(avrg, precision);
                Console.WriteLine("");
                Console.WriteLine("The square root of {0} is {1}.", inputSqrt, avrg);
                Console.ReadLine();
                menu = true;
                break;
               
            }

            }

        }
    }
}