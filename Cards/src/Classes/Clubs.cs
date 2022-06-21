namespace Cards
{
    public class Clubs : Card
    {
        private TypeCard Value { get; set; }
        private string Suits { get; set; }

        private Clubs(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
    }
}