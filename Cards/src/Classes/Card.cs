namespace Cards
{
    public abstract class Card
    {
        private int Id { get; set; }
        private TypeCard Value { get; set; }
        private string Suits { get; set; }

        private Card(int id, TypeCard value, string suits)
        {
            this.Id = id;
            this.Value = value;
            this.Suits = suits;
        }
        private Card() { }
    }
}