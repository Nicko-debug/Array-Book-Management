using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Book
{

    public static class Program 
    {
        public static void Main() 
        {
        Console.WriteLine("WELCOME TO MY BOOK MANAGEMENT");
   
   string studentNumber = "2020-0040-BN-0";
   string studentName = "Nicko Ronem L.Geronaga";
   int studentAge = 20;
   string course = "DICT";
   string yearLevel ="1-1";
   string userName ="Nicko";
   string password ="Toad";
   string[] myArray = {"
Featured Books: ", "Can't Hurt me", "Shutter Island"};
foreach (string item in myArray)
{
  Console.WriteLine(item);
}
   int i = 0;
   for (; i < 3; i++){
   Console.Write("
Enter Username: ");
   string userInput = Console.ReadLine();
   
   Console.Write("Enter Password: ");
   string passwordInput = Console.ReadLine();
   
   if (passwordInput == password && userInput == userName  )
   {
   Console.WriteLine("
Student Information");
   Console.WriteLine("Student Name: " + studentName);
   Console.WriteLine("Student Number: " + studentNumber);
   Console.WriteLine("Student Age: " + studentAge);
   Console.WriteLine("Student Course and year: " + course + " " + yearLevel);
   break;	
   }
   else
   {
   	Console.WriteLine("Invalid USERNAME or PASSWORD!");
   }

}
     if(i==3)
     
   { Console.WriteLine("Applicatin will terminate...");
    Environment.Exit(0);}
}
    
    }
    }
    
 


   
   
    

