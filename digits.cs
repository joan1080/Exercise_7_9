//calculates how many numbers of 1, 2, 3 or more digits are entered by the user until he/she types “end”
using System;

class digits
{
        static void Main()
        {
                string text;
                int oneDigit= 0, twoDigit = 0, threeDigit = 0, moreDigit= 0 , number;     
     
                Console.Write("Insert a number (type 'end' to finish): ");
                text = Console.ReadLine();

                while(text !="end")
                {
                        number= Convert.ToInt32(text);

                       if(number != 0)
                       {
                            if(number/10 == 0)
                               oneDigit ++; 

                            else 
                            if (number/100 == 0)
		                       twoDigit ++;

                            else
                            if (number/1000 == 0)
                                threeDigit ++; 

                            else
                                moreDigit++; 
                        }
                
                        Console.Write("Insert a number (type 'end' to finish): ");
                        text= Console.ReadLine();
                 }

                Console.WriteLine("nº with one digit: {0}// nº with two digits: {1}// nº with three digits: {2}// nº with more digits: {3}", 
                          oneDigit, twoDigit, threeDigit, moreDigit);
        }
}

