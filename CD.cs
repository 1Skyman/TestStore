namespace TestStore
{
    public class CD
    {
        private string sku;
        private string title;
        private string artist;
        private string category;
        private string salesStatus;

        public CD(string sku, string title, string artist, string category, string salesStatus)
        {
            this.sku = sku;
            this.title = title;
            this.artist = artist;
            this.category = category;
            this.salesStatus = salesStatus;
        }
    }
}