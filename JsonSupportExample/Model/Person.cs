using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JsonSupportExample.Model
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "jsonb")]
        public string Address { get; set; }
    }
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
    }


}
