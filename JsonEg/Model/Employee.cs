using System.ComponentModel.DataAnnotations.Schema;

namespace JsonEg.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        [Column(TypeName = "jsonb")]
        public ContactDetails ContactDetails { get; set; }
    }

    public class Contacts
    {
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }

    public class Address
    {
        public string? AddressType { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
    }

    public class ContactDetails
    {
        public Contacts? Contacts { get; set; }
        public List<Address>? Addresses { get; set; }
    }

}
