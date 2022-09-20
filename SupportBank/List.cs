using System;

namespace SupportBank
{
    public class List
    {
        public List<AccountBalance> nameList(List<SupportBankData> statements)
        {
            List<AccountBalance> lists = new List<AccountBalance>();
            var accountHolders = new List<string>();

            foreach (var name in statements)
            {
                if(!accountHolders.Contains(name.OwedTo))
                {
                    accountHolders.Add(name.OwedTo);
                }
            }
            foreach( var account in accountHolders)
            {
                AccountBalance balanceDetail = new AccountBalance
                {
                    BalanceAmount = 0,
                    Name = account,
                    TransactionDetail = new List<SupportBankData>()
                };
                lists.Add(balanceDetail);
            }
            foreach (var transaction in statements)
            {
                foreach(var balance in lists)
                {
                    if(balance.Name == transaction.Emp_Name || balance.Name == transaction.OwedTo)
                    {
                        balance.TransactionDetail.Add(transaction);
                    }
                }
            }
            return lists;
        }
        public List<AccountBalance> AddBalance(List<AccountBalance>lists, List<SupportBankData> statements)
        {
            foreach ( var balance in lists)
            {
                foreach( var transaction in statements)
                {
                    if (balance.Name == transaction.OwedTo)
                    {
                        balance.BalanceAmount = balance.BalanceAmount - transaction.Amount;
                    }
                    if (balance.Name == transaction.Emp_Name)
                    {
                        balance.BalanceAmount = balance.BalanceAmount + transaction.Amount;
                    }
                }
            }
            return lists;
        }
    }
}