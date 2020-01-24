
using Microsoft.AspNetCore.Identity;

namespace Domain
{
  public class AppUser : IdentityUser // Dependency Injection required.
  {
    public string DisplayName { get; set; }
  }
}