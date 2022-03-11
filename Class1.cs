using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Class1
    {
        int year;
        Random obj = new Random();
        int h = 0;
        int t = 0;
        int coin;
        public void LeapYear()
        {
            Console.WriteLine("Enter Year : ");
            int year =int.Parse(Console.ReadLine());

            if((year%4==0)&&(year%100!=0)||(year%400==0))
            {
                Console.WriteLine("is a LeapYear", year);
            }
            else
            {
                Console.WriteLine("not Leapyear", year);
                Console.ReadLine();
            }
        }
       
        public void HeadTail()
        {
            
            Console.WriteLine("Enter No: ");
            coin = Convert.ToInt32(Console.ReadLine());
            while(coin>0)
            {
                int randomCheck = obj.Next(2);
                if(randomCheck==0)
                {
                    h++;

                }
                else
                {
                    t++;
                }
                coin--;
            }
            Console.WriteLine("Heads = " + h);
            Console.WriteLine("Tails =" + t);
        }
    }
}
