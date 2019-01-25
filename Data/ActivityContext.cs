using  Microsoft.EntityFrameworkCore;
using Activity.Models;

namespace Activity.Data
{
    public class ActivityContext : DbContext
    {
        public ActivityContext(DbContextOptions<ActivityContext> options) : base(options){}
        public DbSet<User> Users{get;set;}
        public DbSet<Event> Events {get;set;}
        public DbSet<Participant> Participants {get;set;}
    }
}