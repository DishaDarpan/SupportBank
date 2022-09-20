using System;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace SupportBank
{
    public class FileReader
    {
        private string FileName {get; set;}
        public List<SupportBankData> Read(string FileName)
        {
            List<SupportBankData> empDetails =new List<SupportBankData>();
            var data = File.ReadAllLines(FileName).Skip(1);

            foreach (string rowData in data)
            {
                string[] rowDetail = rowData.Split(',');
                DateTime date = DateTime.Parse(rowDetail[0]);
                string owedFrom = rowDetail[1];
                string owedTo = rowDetail[2];
                string narrative = rowDetail[3];
                float amount = float.Parse(rowDetail[4]);
            
                SupportBankData transactionDetail = new SupportBankData
                {
                    Date = date,
                    Emp_Name = owedFrom,
                    OwedTo = owedTo,
                    Narrative = narrative,
                    Amount = amount,
                };
                empDetails.Add(transactionDetail);
        }
        return empDetails;
    }
    }
}