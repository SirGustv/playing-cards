namespace Cards
{
    public abstract class Card
    {
        private TypeCard Value { get; set; }
        private string Suits { get; set; }

        private Card(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
        public Card() { }
    }
}