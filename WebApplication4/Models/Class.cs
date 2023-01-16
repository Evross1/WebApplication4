using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication4.Models
    
{
    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Quanity { get; set; }
        public string? State { get; set; }
    }
}