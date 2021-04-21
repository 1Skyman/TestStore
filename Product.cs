namespace TestStore
{
    public class Product:CD
    {
        public int Number { get; set; }
        public string Description { get; set; }

        public Product(string sku, string title, string artist, string category, string salesStatus) : base(sku, title, artist, category, salesStatus)
        {
            
        }
    }
}