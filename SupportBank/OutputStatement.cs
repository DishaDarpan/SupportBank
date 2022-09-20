using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace SupportBank
{
    public class OutputStatement
    {
        public string Menu()
        {
            Console.WriteLine("Please select 1 or 2 from following options: ");
            Console.WriteLine("1. Display Balance");
            Console.WriteLine("2. Mini Statement");
            string selection = Console.ReadLine();
            return selection;
        }

        public void DisplayList(string selection, List<SupportBankData> transcations, List<AccountBalance> statement)
        {
            var employeeList = new List<string>();
            foreach (var data in transcations) 
            {
                if(!employeeList.Contains(data.OwedTo))
                {
                    employeeList.Add(data.OwedTo);
                }
            }
            string emp_names = String.Join(", ",employeeList.ToArray());

            if (selection == "1")
            {
                foreach (var account_data in statement)
                {
                    Console.WriteLine($"Name: {account_data.Name}, Account-Balance: £{account_data.BalanceAmount}");
                }
            }
            else if (selection == "2")
            {
                Console.WriteLine("Enter the name of Account holder: ");
                string getName = Console.ReadLine();
                foreach(var account_data in statement)
                {
                    if (account_data.Name == getName)
                    {
                        Console.WriteLine($"Account Details of {account_data.Name} :");
                        Console.WriteLine();
                    
                    foreach (var details in account_data.TransactionDetail)
                    {
                        Console.WriteLine($"Employee Name : ${details.Emp_Name}, Owed To : ${details.OwedTo}, Reference : ${details.Narrative}, Amount : ${details.Amount}");
                    }
                    }
                    
                }
            }
        }
    }
}