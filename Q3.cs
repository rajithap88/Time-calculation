using System;

namespace ConsoleApp1
{
    class Program
    {
        private static object exit;

        static void Main(string[] args)
        {
            //take input
            string val;
            Console.WriteLine("Enter normal time in the format of hh:mm:ss to covert to USF time: ");
            val = Console.ReadLine();
            string someString = val;
            DateTime someDate;
            try
            {
                someDate = DateTime.Parse(someString);
                Console.WriteLine(String.Format("Hey, {0} is a valid DateTime!", someString));
            
            //convert normal time to total seconds
            TimeSpan ts = TimeSpan.Parse(val);
            double totalSeconds = ts.TotalSeconds;
            Console.WriteLine(totalSeconds);
            bool stopProgram = false;
            while (stopProgram == false)
            {
                if (totalSeconds > 43200)
                {
                    Console.WriteLine("Kindly enter time in 12 hour format.As the input time is an invalid input(more than 12 hours),exiting the application");
                    stopProgram = true;
                }
                
                else
                {
                    //convert to USF time
                    double totalUSFSeconds = 2.266536673166342 * (totalSeconds);
                    Console.WriteLine(totalUSFSeconds);
                    //calculating hour value
                    Double hour = totalUSFSeconds / 2655;
                    //Console.WriteLine(hour);
                    int hours = (int)(hour);
                    // Console.WriteLine(hours);

                    //calculating minute value
                    Double totalSecondinhour = hours * (2655);
                    //Console.WriteLine(totalSecondinhour);
                    Double remainingsec = ((totalUSFSeconds) - (totalSecondinhour));
                    //Console.WriteLine(remainingsec);
                    Double minute = remainingsec / 59;
                    //Console.WriteLine(minute);
                    int minutes = (int)(minute);
                    // Console.WriteLine(minutes);

                    //calculate second value
                    Double totalSecondinminute = minutes * (59);
                    //Console.WriteLine(totalSecondinminute);
                    Double remainingseconds = ((remainingsec) - (totalSecondinminute));
                    // Console.WriteLine(remainingseconds);
                    int seconds = (int)(remainingseconds);
                    // Console.WriteLine(seconds);

                    Console.WriteLine(hours + ":" + minutes + ":" + seconds);
                    stopProgram = true;
                }
            }
            }
             catch
            {
                // someString must not have been a valid DateTime!
                // Console.WriteLine($"Hey, {someString} is not a valid DateTime!"); 
                Console.WriteLine(String.Format("Hey, {0} is not a valid DateTime!", someString));
            }
            /*string someString = "1:000";
            DateTime someDate;

            try
            {
                someDate = DateTime.Parse(someString);
                Console.WriteLine(String.Format("Hey, {0} is a valid DateTime!", someString));
            }
            catch
            {
                // someString must not have been a valid DateTime!
                // Console.WriteLine($"Hey, {someString} is not a valid DateTime!"); 
                Console.WriteLine(String.Format("Hey, {0} is not a valid DateTime!", someString));
            }*/

        }
    }
}
