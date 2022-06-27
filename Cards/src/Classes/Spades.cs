namespace Cards
{
    public class Spades : Card
    {
        private Spades(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
    }
}