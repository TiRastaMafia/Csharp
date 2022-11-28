using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {

Console.Write("Enter a three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine(threeDigitNumber + " The two digit of this number -> "+stringNumber[1]);


            
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {

Console.Write("Enter a three-digit number: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
if (threeDigitNumber <= 99)
Console.WriteLine(" There is no third digit"); 
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine(threeDigitNumber + " The third digit of this number -> "+stringNumber[2]);           
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {

Console.Write("Enter the number indicating the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
{
  Console.WriteLine(dayNumber + " This day is a day off -> yes");
}
  else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine(dayNumber + " not a day of the week at all");
}
  else Console.WriteLine(dayNumber + " It's a working day ");
}

CheckingTheDayOfTheWeek(dayNumber);
            
        }
    }
}