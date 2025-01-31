using System.ComponentModel.Design;
using System.Transactions;

namespace Comp_003A.CodingAssignment3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Management");
            Console.WriteLine("Enter your monthly income: ");
            int income = int.Parse(Console.ReadLine());


            int choice;
            int budget;

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
                    Console.WriteLine("Enter the expense name: ");
                    Console.ReadLine(); 
                    Console.WriteLine("Enter the Expense amount: ");
                    int num = int.Parse(Console.ReadLine());
                   
                }







                else if (choice == 2) 
                {
                    Console.WriteLine("Total Expenses: ");
                    Console.WriteLine("Remaing Budget: ");

                }



                else if (choice == 3)
                { 
                    Console.WriteLine("Enter the name of the expense to remove: ");
                    Console.WriteLine("Expense removed successfully");
                }


                else if (choice == 4) 
                {
                    Console.WriteLine("\n\nGoodbye!"); break;
                }

                else { Console.WriteLine("\nInvalid input"); }
               

            }


            


















        }
    }
}
