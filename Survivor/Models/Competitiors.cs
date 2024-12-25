using System.ComponentModel.DataAnnotations.Schema;

namespace Survivor.Models
{
    public class Competitiors : BaseEntity<int>
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
