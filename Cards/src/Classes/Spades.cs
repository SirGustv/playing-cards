namespace Cards
{
    public class Spades : Card
    {
        private TypeCard Value { get; set; }
        private string Suits { get; set; }

        private Spades(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
    }
}