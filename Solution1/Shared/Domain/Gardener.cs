namespace Shared.Domain;

public class Gardener
{
    public string Username { get; set; }
    public string Password { get; set; }
    
    public NotificationPreferences Preferences { get; set; }
}