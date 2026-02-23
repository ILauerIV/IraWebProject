using Microsoft.AspNetCore.Identity;

namespace IraWebProject.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public int BackgroundColor { get; set; }   
}

