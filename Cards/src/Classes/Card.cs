namespace Cards
{
    public abstract class Card
    {
        protected TypeCard Value { get; set; }
        protected string Suits { get; set; }

        protected Card(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
        protected Card() { }

    }
}