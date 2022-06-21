namespace Cards
{
    public class Hearts : Card
    {
        private TypeCard Value { get; set; }
        private string Suits { get; set; }

        private Hearts(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
    }
}