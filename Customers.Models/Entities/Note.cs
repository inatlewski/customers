using System.Runtime.Serialization;

namespace Customers.Models.Entities
{
    public class Note
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        [IgnoreDataMember]
        public Customer Customer { get; set; }

        public string Content { get; set; }
    }
}