using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDataStructurePrograms
{
    public class BankCashCouter
    {
        public void BankingCashCounter()
        {
            Queue<string> list = new Queue<string>();
            Console.WriteLine("Enter the Number of people in Queue in front of Cash Counter");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] Names = new string[number];
             double[] account = new double[number];
            Console.WriteLine("Specify the Names of People and their Account Balance : ");
            for (int i = 0; i < number; i++)
            {
                Names[i] = Console.ReadLine();
                account[i] = Convert.ToDouble(Console.ReadLine());
                list.Enqueue(Names[i]);
            }
            for (int j = 0; j < Names.Length; j++)
            {
                Console.WriteLine("person : {0}  Account Balance : {1}", Names[j], account[j]); 
                Console.WriteLine("Select Option : \n 1. Balance Enquiry \n 2.Deposit \n 3. Withdrawl"); 
                int choice = Convert.ToInt32(Console.ReadLine()); 
                switch (choice)
                { 
                    case 1:
                        Console.WriteLine("Your Account balance is : " + account[j]);
                        break;
                    case 2:
                        Console.WriteLine("Enter The Amount To Deposit : ");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Amount Deposited is " + deposit);
                        account[j] += deposit;
                        Console.WriteLine("Total Balance = " + account[j]);
                        list.Dequeue();
                        break;
                    case 3:
                        Console.WriteLine("Enter The Amount To Withdraw : ");
                        double withdrawl = Convert.ToDouble(Console.ReadLine());
                        if (withdrawl <= 20000 && account[j] > 0)
                        {
                            if (withdrawl <= account[j])
                            {
                                Console.WriteLine("Amount Withdrawl is : " + withdrawl);
                                account[j] -= withdrawl;
                                Console.WriteLine("Total Balance = " + account[j]);
                                list.Dequeue();
                            }
                            else
                            {
                                Console.WriteLine("Insufficient Balance In Your Account");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry--- The Cash Withdrawl limit is 20000 per transaction/day \n Please enter below or 20000");
                        }
                        break;
                    default: 
                        Console.WriteLine("Select an Option");  
                        break; 
                }
            } 
        }  
    } 
} 