using System.ComponentModel.DataAnnotations;

public class Product
{
    /*[Key]*/ // Look if I can change this to fluent API = Done
    public long Id { get; set; }
    public string? Brand { get; set; }
    public string? Title { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}