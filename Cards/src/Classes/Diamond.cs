namespace Cards
{
    public class Diamonds : Card
    {
        private TypeCard Value { get; set; }
        private string Suits { get; set; }

        private Diamonds(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
    }
}