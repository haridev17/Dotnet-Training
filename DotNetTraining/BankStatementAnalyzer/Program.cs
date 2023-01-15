namespace Analyzer{


    class Analyzer
    {
        static void Main()
        {
            var analyzer = new StatementAnalyser();
            analyzer.StatementLoad("C:\\Users\\harid\\source\\repos\\DotNetTraining\\BankStatementAnalyzer\\test.csv");

            Console.WriteLine("Printing total net balance");
            analyzer.GetStatement();

            Console.WriteLine("MOnthly balance");
            analyzer.GetMonthlyStatement();


        }
    }
}