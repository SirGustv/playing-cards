namespace Cards
{
    public class Hearts : Card
    {
        private Hearts(TypeCard value, string suits)
        {
            this.Value = value;
            this.Suits = suits;
        }
    }
}