using Microsoft.AspNetCore.Identity;
using NodaTime;

namespace API.Models;

public class AppUser : IdentityUser<int>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public Instant CreatedAt { get; set; } = Instant.FromDateTimeUtc(DateTime.UtcNow);
    public ICollection<BoardMember> BoardMemberships { get; } = new List<BoardMember>();
    public ICollection<Board> Boards { get; } = new List<Board>();
    public ICollection<Card> AssignedCards { get; } = new List<Card>();
    public ICollection<Comment> Comments { get; } = new List<Comment>();
    public ICollection<ActivityLog> ActivityLogs { get; } = new List<ActivityLog>();
}
