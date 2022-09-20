namespace Bank
{
    class Debt
    {
        private int accountId; 
        public int AccountId {get;set;} 
        private string to; //other persons id
        public string To {get;set;}
        private decimal amount;
        public decimal Amount {get;set;} 
        private DateTime date;
        public DateTime Date {get;set;}
        private string? narrative;
        public string? Narrative{get; set;}

        public Debt(int id, string to, decimal amount, DateTime date, string narrative)
        {
            this.AccountId = id;
            this.To = to;
            this.Amount = amount;
            this.Date = date;
            this.Narrative = narrative;
        }
    }

}