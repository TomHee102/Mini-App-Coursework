using System;

namespace MiniApps
{
    class KeepCounting
    {
        public static void Main(string[] args)
        {
            while (true)
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
                        Console.WriteLine("Try again");
                        question = 0;
                    }

                }

                Console.WriteLine("Finish!");

            }

        }
    }
}
