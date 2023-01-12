namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck mydeck = new Deck();
            Console.WriteLine("printing deck");
            foreach (Card c in mydeck.Cards)
            {   
                Console.WriteLine(c);
            }
   
        }
        static Random r = new Random();
        static public void Shuffle(int[] deck)
        {
            for (int n = deck.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                int temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
                
            }
            Console.WriteLine(deck);

        }

    }
}