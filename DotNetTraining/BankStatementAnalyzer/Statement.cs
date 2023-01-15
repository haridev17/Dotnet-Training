namespace Analyzer{


    public class Statement
    {
        public DateOnly Date { get; set; }
        public double Amount { get; set; }
        public string Details { get; set; }

        public override string ToString()
        {
            if (Amount > 0)
            {
                return $"Rupees {Amount} credited to your account on {Date.ToString()}, Remarks:{Details}";
            }
            else
            {
                return $"Rupees {Amount} debited from your account on {Date.ToString()}, Remarks:{Details}";
            }
           
        }
    }
}