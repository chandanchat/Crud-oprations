using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Emp
    {
        [Key]
        public int id {get;set;}
    public string? name {get;set;}
        public int age { get; set; }
    }
}
