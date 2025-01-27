//fabonaicii series 
//Task1: print upto range 
//Task2: Print n fabonacii number 
using System;
class Fabonacii{
	static void Main(string []args){
		Console.Write("Enter the number: ");
		//taking the input from the user
		int num=Convert.ToInt32(Console.ReadLine());
		int sum=0;
		//putting it in a loop so that numbers keep added in sum in order to gain fabonacii series 
		for (int i=0;i<=num;i++){
			sum +=i;
			Console.Write(sum + " ");
		}
		//Console.WriteLine("fabonacii number is:" + sum);
	}
	}