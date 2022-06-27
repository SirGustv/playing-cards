namespace Cards
{
    public class Diamonds : Card
    {
        private Diamonds(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
    }
}