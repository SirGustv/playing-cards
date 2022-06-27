namespace Cards
{
    public abstract class Card
    {
        public TypeCard Value { get; set; }
        public string Suits { get; set; }

        public Card(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
        public Card() { }


    }
}