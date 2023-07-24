using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JsonSupportExample.Model
{
    public class JsonTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // Use this mapping for PostgreSQL 9.4 and higher
        [Column(TypeName = "jsonb")]
        public string JObject { get; set; }

        public string Text { get; set; }
    }
}
