namespace ConsoleApplication1
{
    class Card
    {
        protected Suits suit;
        protected string cardvalue;
        public Card(Suits suit2, string cardvalue2)
        {
            suit = suit2;
            cardvalue = cardvalue2;
        }
        public override string ToString()
        {
            return ($"{cardvalue} of {suit}");
        }
    }
}