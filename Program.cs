// Author: Andrew Cruz Pacheco
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstarting control flow.

using System.ComponentModel.Design;
using System.Transactions;

namespace Comp_003A.CodingAssignment3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double budget ;
            string expenseName1 = "";
            double expenseAmount1 = 0;
            double removeExpense = 0;             //   wont work cuz ones a string and oter is a double (fixed)

            Console.WriteLine("Welcome to the Budget Management Tool!\n");
            Console.Write("Enter your monthly income:  ");
            budget = double.Parse(Console.ReadLine());



            while (true)
            {
                Console.WriteLine("Menu:");

                Console.WriteLine("1. Add an expense");
                Console.WriteLine("2. View expenses and budget");
                Console.WriteLine("3. Remove an expense"); 
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                
                if (choice == 1)
                {
                    Console.Write("\nEnter an expense name: ");
                    expenseName1 = Console.ReadLine();
                    Console.Write("Enter an amount: ");
                    expenseAmount1 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Expense added sucessfully!\n");

                }


                else if (choice == 2) 
                {                                                   // done
                    Console.WriteLine("\nExpenses:");
                    Console.WriteLine($"- {expenseName1}: ${expenseAmount1:F2} ");
                    Console.WriteLine($"Total Expenses: ${expenseAmount1}");

                    double RemaingBudget = (budget - expenseAmount1);
                    Console.WriteLine($"Remaining Budget: ${RemaingBudget}\n");

                }





                else if (choice == 3)
                { 
                    
                   Console.WriteLine("\nEnter the name of the expense to remove: ");
                 //  removeExpense = double.Parse( Console.ReadLine());

                //    expenseAmount1 = 0;
                   // if (removeExpense == expenseAmount1) ;
              //      {
             //           double RemaingBudget = (budget + expenseAmount1);
              //          Console.WriteLine($"Remaining Budget: ${RemaingBudget}\n");


                  
                    Console.WriteLine("Expense removed successfully!\n");
                        
              //      }


                }





                else if (choice == 4) 
                {
                    Console.WriteLine("\n\nGoodbye!"); break;
                }

                else { Console.WriteLine("\nInvalid input\n"); }
               

            }


            


















        }
    }
}
