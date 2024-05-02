namespace store.Db;

using store.Models;

public class AppDbContext : IdentityDbContext<UserSecretsConfigurationExtensions, IdentityRole<int>, int>
{
    static AppDbContext() 
    {
        
    }
}