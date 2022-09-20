using System;

namespace SupportBank 
{
    public class AccountBalance
    {
        public string Name {get; set;}
        public float BalanceAmount {get; set;}
        public List<SupportBankData> TransactionDetail {get; set;}
    }
}