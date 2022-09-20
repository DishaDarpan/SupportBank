using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using NLog;
using NLog.Config;
using NLog.Targets;


namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new LoggingConfiguration();
            var target = new FileTarget { FileName = @"C:\Work\Logs\SupportBank.log", Layout = @"${longdate} ${level} - ${logger}: ${message}" };
            config.AddTarget("File Logger", target);
            config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, target));
            LogManager.Configuration = config;
            
            OutputStatement miniStatement = new OutputStatement();
            string filePath = @"./Transactions2014.csv";
            FileReader readFile = new FileReader();
            var empDetails = readFile.Read(filePath);
            List accountList = new List();
            var accounts = accountList.nameList(empDetails);
            var finalDetails = accountList.AddBalance(accounts, empDetails);
            string input = miniStatement.Menu();
            miniStatement.DisplayList(input, empDetails, finalDetails);

        }
    }
}

