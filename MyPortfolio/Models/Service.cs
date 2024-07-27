namespace MyPortfolio.Models
{
    public class Service
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public Service(int key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
