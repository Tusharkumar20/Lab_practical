using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to the TENANT house provider!");
            Console.WriteLine("Enter your name:");
          string name = Console.ReadLine();
          Console.WriteLine("Hello, " + name + "!");
          Console.WriteLine("select your plan : \n1. Basic(1000)\n2. Premium(2000) 10% off\n3. Pro(3000) 20% off");
           Console.WriteLine("Enter the number corresponding to your plan:");
            int plan = int.Parse(Console.ReadLine());
           for (int i = 0; i < 3; i++)
           {
               if (plan == 1)
               {
                   Console.WriteLine("You have selected the Basic plan (1000). ");
                   break;
               }
               else if (plan == 2)
               {
                   Console.WriteLine("You have selected the Premium plan (2000). In this plan you get 10% off");
                   break;
               }
               else if (plan == 3)
               {
                   Console.WriteLine("You have selected the Pro plan(3000).In this plan you get 20% off ");
                   break;
               }
               else
               {
                   Console.WriteLine("Invalid selection. Please try again.");
                   plan = int.Parse(Console.ReadLine());
               }
           }
           Console.WriteLine("please select the usage type : \n1. Personal\n2. Business");
           int usageType = int.Parse(Console.ReadLine());
           for (int i = 0; i < 3; i++)
           {
               if (usageType == 1)
               {
                   Console.WriteLine("You have selected Personal usage.Now proceeding to payment...");
                   break;
               }
               else if (usageType == 2)
               {
                   Console.WriteLine("You have selected Business usage.Now proceeding to payment...");
                   break;
               }
               else
               {
                   Console.WriteLine("Invalid selection. Please try again.Now proceeding to payment...");
                   usageType = int.Parse(Console.ReadLine());
               }

           }
        }
    }
}
