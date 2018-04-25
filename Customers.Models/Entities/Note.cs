namespace Customers.Models.Entities
{
    public class Note
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string Content { get; set; }
    }
}