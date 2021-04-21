namespace TestStore
{
    public class Inventory:CD
    {
        private string store;
        private int zipCode;

        public Inventory(string sku, string title, string artist, string category, string salesStatus) : base(sku, title, artist, category, salesStatus)
        {
            
        }
    }
}