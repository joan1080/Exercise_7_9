
//calculates the average of a set of marks, until the user types “end”.
using System;

public class Average
{
		public static void Main()
		{
				string text;
				double totalSum = 0, number, counterNumber=0, average;

				Console.Write("Insert a number (type 'end' to finish):: ");
				text=Console.ReadLine();	

				while(text!="end")
				{  
						number=Convert.ToDouble(text);
						counterNumber++;   
						totalSum+=number;  

						Console.Write("Insert a number (type 'end' to finish): ");
						text=Console.ReadLine();
				}

				if(counterNumber!=0)
				{
						average=totalSum/counterNumber;  
		
						Console.WriteLine("The average is {0}.",average);
				}
			}
}
