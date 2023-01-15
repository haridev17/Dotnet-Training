namespace Analyzer{
    class StatementAnalyser
    {
        public List<Statement> Transactions { get; set; } = new List<Statement>();
        public double NetBalance { get; set; }

        public void StatementLoad(string filePath)
        {
            using (var fileReader = new StreamReader(filePath))
            {
                while (!fileReader.EndOfStream)
                {
                    var row = fileReader.ReadLine();
                    var values = row.Split(',');

                    var date = DateOnly.ParseExact(values[0], "dd-MM-yyyy", null);
                    var amount = double.Parse(values[1]);
                    var details = values[2];

                    var transaction = new Statement
                    {
                        Date = date,
                        Amount = amount,
                        Details = details
                    };

                    Transactions.Add(transaction);
                    NetBalance += amount;
                }
            }
        }

        public void GetStatement()
        {
            foreach (var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
            Console.WriteLine($"Total Net Balance: {NetBalance}");
        }

        public void GetMonthlyStatement()
        {
            Console.Write("Enter the month to find the monthly balance (eg: 02 for february):");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter the year to find the monthly balance (eg: 2022):");
            int year = int.Parse(Console.ReadLine());

  
            double monthlyBalance = 0;
            foreach (var transaction in Transactions)
            {
                if (transaction.Date.Month == month && transaction.Date.Year == year)
                {
                    monthlyBalance += transaction.Amount;
                }
            }
            Console.WriteLine($"Net Balance for the month {month}/{year}: {monthlyBalance}");
        }
    }
}