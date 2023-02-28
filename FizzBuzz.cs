using System;
 
namespace FizzBuzz
{
    public class FB {         
        public static void Main(string[] args)
        {
            string userInput;
            int userNum;
            
            while (true){
            
                Console.WriteLine("Enter Input (0 or less to quit) :");
            
                userInput = Console.ReadLine();
                userNum = Convert.ToInt32(userInput);
                
                // keep asking for input unless the number is 0 or neg
                if (userNum <= 0){
                    Console.WriteLine("Quiting...");
                    break;
                }
                
                if (userNum % 3 == 0 && userNum % 5 == 0){
                    Console.WriteLine("FizzBuzz");
                } else if (userNum % 3 == 0){
                    Console.WriteLine("Fizz");
                } else if (userNum % 5 == 0){
                    Console.WriteLine("Buzz");    
                } else {
                    Console.WriteLine("Not divisible by 3 or 5!!");
                }
                
            }// end while loop
        }
    }
}