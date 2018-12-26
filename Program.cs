

//                    The Survey
//    1. Create a Data Class to store information of surveyee.
//    2. Collect input from surveyee.
//    3. Display surveyee information and Zodiac sign ()


using System;

namespace Survey_Challenge
{
    class Data
    {
        //  The Data Constructor handles setting its own members.
        // This could and probably should be optional.
        public Data()
        {
            Console.WriteLine("New Survery Created!");
            SetAllData();
            Display();
        }

        public string Name;
        public int Age;
        public string Month;
        public int Day;

        public void SetAllData()
        {
            Console.WriteLine("What is your name?");
            Name = TryAnswer();
            RequestInt(out Age, "What is your age?");
            Console.WriteLine("What month were you born in?");
            Month = TryAnswer();
            RequestInt(out Day, "What day were you born on?");
        }

        private string TryAnswer()
        {
            var question = Console.ReadLine();
            while (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                question = Console.ReadLine();
            }
            return question;
        }

        private void RequestInt(out int intRef, string question)
        {
            string tempStr;
            while (true)
            { 
                Console.WriteLine(question);
                tempStr = TryAnswer();
                var isNumeric = int.TryParse(tempStr, out var result);
                if (isNumeric)
                {
                    intRef = result;
                    return;
                }
                else
                {
                    Console.WriteLine("Error: #87 Improper Input: '{0}' is not an integer!\n", tempStr);
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("You where born on day: {0} of the month: {1}", Day, Month);

            switch (Month)
            {
                case "march":
                case "March":
                    {
                        if(Day >= 21)
                        {
                            Console.WriteLine("you are an Aries.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Pisces.");
                        }
                        break;
                    }
                case "april":
                case "April":
                    {
                        if (Day >= 20)
                        {
                            Console.WriteLine("you are a Taurus.");
                        }
                        else
                        {
                            Console.WriteLine("you are an Aries.");
                        }
                        break;
                    }
                case "may":
                case "May":
                    {
                        if (Day >= 21)
                        {
                            Console.WriteLine("you are a Gemini.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Taurus.");
                        }
                        break;
                    }
                case "june":
                case "June":
                    {
                        if (Day >= 21)
                        {
                            Console.WriteLine("you are a Cancer.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Gemini.");
                        }
                        break;
                    }
                case "july":
                case "July":
                    {
                        if (Day >= 23)
                        {
                            Console.WriteLine("you are a Leo.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Cancer.");
                        }
                        break;
                    }
                case "august":
                case "August":
                    {
                        if (Day >= 23)
                        {
                            Console.WriteLine("you are a Virgo.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Leo.");
                        }
                        break;
                    }
                case "september":
                case "September":
                    {
                        if (Day >= 23)
                        {
                            Console.WriteLine("you are a Libra.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Virgo.");
                        }
                        break;
                    }
                case "october":
                case "October":
                    {
                        if (Day >= 23)
                        {
                            Console.WriteLine("you are a Scorpio.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Libra.");
                        }
                        break;
                    }
                case "november":
                case "November":
                    {
                        if (Day >= 22)
                        {
                            Console.WriteLine("you are a Sagittarius.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Scorpio.");
                        }
                        break;
                    }
                case "december":
                case "December":
                    {
                        if (Day >= 22)
                        {
                            Console.WriteLine("you are a Capricorn.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Sagittarius.");
                        }
                        break;
                    }
                case "january":
                case "January":
                    {
                        if (Day >= 20)
                        {
                            Console.WriteLine("you are an Aquarius.");
                        }
                        else
                        {
                            Console.WriteLine("you are a Capricorn.");
                        }
                        break;
                    }
                case "february":
                case "February":
                    {
                        if (Day >= 19)
                        {
                            Console.WriteLine("you are a Pisces.");
                        }
                        else
                        {
                            Console.WriteLine("you are an Aquarius.");
                        }
                        break;
                    }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            //   Stop the console from closing automatically
            // by calling Console.ReadLine();
            Console.ReadLine();
        }
    }
}
