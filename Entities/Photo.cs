using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;

[Table("Photos")]
public class Photo
{
    public int id { get; set; }
    public required string Url { get; set; }
    public string? PublicId { get; set; }
    public bool IsMain { get; set; }
    //Navigation Properties
    public int AppUserId { get; set; }
    public AppUser AppUser { get; set; } = null!;

}