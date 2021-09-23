using System;
using System.Collections.Generic;



namespace PrimeShift.Models
{
  public class PrimeNum
  {
    public int prime = 2;
    public static void Main()
    {
      Console.WriteLine("Enter a number or I'll kick your teeth in");
      string input = Console.ReadLine();
      int number = Convert.ToInt32(input);
      PrimeNum OmegaPrime = new PrimeNum();
      OmegaPrime.Prime(number);
    }
    public void Prime(int number)
    {
      List<int> numbers = new List<int>();
      for(int i = 2; i <= number; i++){
        if(i%2 == 0 && i != 2 || i%3 == 0 && i != 3 || i%5 == 0 && i != 5 || i%7 == 0 && i != 7)
        {
        Console.WriteLine("This number survived");
        } else if(i%prime != 0 || i == 2 || i == 3 || i == 5 || i == 7)
        {
         numbers.Add(i);
        }
      }
      numbers.ForEach(num => Console.WriteLine(num + " "));
    }
  }
}

// While prime = 2
// run the for loop
// prime = 3
// run the for loop again
//  / C# program to add element in List<T>
// using System;
// using System.Collections.Generic;
  
// class Geeks {
  
//     // Main Method
//     public static void Main(String[] args)
//     {
  
//         // Creating a List of integers
//         List<int> firstlist = new List<int>();
  
//         // adding elements in firstlist
//         for (int i = 4; i < 10; i++) {
//             firstlist.Add(i * 2);
//         }
  
//         // Displaying elements of firstlist
//         // by using foreach loop
//         foreach(int element in firstlist)
//         {
//             Console.WriteLine(element);
//         }