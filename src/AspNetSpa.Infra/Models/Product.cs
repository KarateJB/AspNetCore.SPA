namespace AspNetSpa.Infra.Models
{
    /// <summary>
    /// Product
    /// </summary>
    public class Product
    {
        public string Id { get; set; }
        public string  TypeId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}