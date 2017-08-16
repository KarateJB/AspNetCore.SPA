namespace AspNetSpa.Infra.Models.DTO
{
    /// <summary>
    /// Product
    /// </summary>
    public class Product
    {
        public string Id { get; set; }
        public int  TypeId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}