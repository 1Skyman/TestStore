namespace TestStore
{
    public class Customer:In_StoreHold
    {
        private string email;
        private string lastName;
        private string firstName;
        private string address;
        private string city;
        private string state;
        private int zipcode;
        private int dayTimePhone;

        public Customer(string sku, string title, string artist, string category, string salesStatus) : base(sku, title, artist, category, salesStatus)
        {
            
        }
    }
}