using System.ComponentModel.DataAnnotations.Schema;

namespace Survivor.Models
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; } = "";
        public List<Competitiors> Competitiors { get; set; } = new List<Competitiors>();
    }
}
