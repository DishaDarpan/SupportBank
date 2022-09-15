using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;


namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] transactionCSV = File.ReadAllLines("./Transactions2014.csv");

           
            var names = new List<string>();
            var owedFrom = new List<string>();
            var owedTo = new List<string>();
            var date = new List<DateTime>();

            for (int i = 0; i < transactionCSV.Length; i++)
            {
                string[] row = transactionCSV[i].Split(',');
                if(!names.Contains(row[1]))
                {
                    names.Add(row[1]);
                }
            }
            for (int i = 0; i < transactionCSV.Length; i++)
            {
                string[] row = transactionCSV[i].Split(',');
// row [ 0=> date, 1=>from, 2=>to, 3=>narative,4=>amount ]
                if (names.Contains(row[1]))
                {
                    SupportBankData something = new SupportBankData(( row[1], row[2], row[3]) );                 

                }
            }

            // for (int i = 0; i < names.Count; i++)
            // {
            //     Console.WriteLine(names[i]);
            // }
            // Console.WriteLine(names.Count);

            // for (int i = 0; i < transactionCSV.Length; i++)
            // {
            //     string[] row = transactionCSV[i].Split(',');
            //     owedFrom.Add(row[1]);
            //     owedTo.Add(row[2]);
            //     date.Add(DateTimeToString.row[0])
            // }
            // for (int i = 0; i < owedFrom.Count; i++)
            // {
            //     Console.WriteLine(owedFrom[i]);

            // }

            Console.ReadKey();
        }
    }
}

