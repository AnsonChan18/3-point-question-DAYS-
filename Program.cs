using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_3_points
{
    internal class Program
    {
        static void Day_Format()
        {
            //defining the properties of the list
            List<Int16> list = new List<Int16>();
            List<string> authors = new List<string>(5);



            //prompt the user to enter the day in numbers
            Console.WriteLine("Enter the day in numbers: ");

            //read the input and store as variable
            string _day = Console.ReadLine();

            //converting the input to integer to compare
            int _numday = (Convert.ToInt32(_day) -1);



            //prompt the user to enter the format to return
            Console.WriteLine("Enter the format to return (Day: full name of day/ shortday: shortend name of day/ char: first or first two characters of day): ");
            
            //read the user input
            string _format = Console.ReadLine();
            



            //setup the lists
            //list of full name of days
            string[] _days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //list of shortened name of days
            string[] _shortday = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            
            //list of the first characters of name of days
            string[] _charday = { "M", "Tu", "W", "Th", "F", "Sa", "Su" };
            




            //decision of what format did the user enter
            //if the user entered "day"
            if (_format == "day")
            {
                //output the item in the _numdayth position on the list
                Console.WriteLine(_days[_numday]);
            }


            //if the user entered "shortday"
            else if (_format == "shortday")
            {
                Console.WriteLine(_shortday[_numday]);
            }


            //if the user entered "char"
            else if ( _format == "char")
            {
                Console.WriteLine(_charday[_numday]);
            }


            //if the user entered an invalid pair of values
            else
            {
                //prompt to tell the user the input is incorrect
                Console.WriteLine("invalid pair of input, please try again");
                
                //restart the function
                Day_Format();
            }
        }
        static void Main(string[] args)
        {
            //calling the function
            Day_Format();
            //pause to let the user know the results
            Console.ReadLine();
        }
    }
}
