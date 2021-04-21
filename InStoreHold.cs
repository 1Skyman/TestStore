namespace TestStore
{
    public class In_StoreHold:Inventory
    {
        private int date;

        public In_StoreHold(string sku, string title, string artist, string category, string salesStatus) : base(sku, title, artist, category, salesStatus)
        {
            
        }
    }
}