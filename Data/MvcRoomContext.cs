using Microsoft.EntityFrameworkCore;
using MvcAdv.Models;

namespace MvcRoom.Data
{
    public class MvcRoomContext : DbContext
    {
        public MvcRoomContext (DbContextOptions<MvcRoomContext> options) : base(options)
        {
        }

        public DbSet<Room> Room { get; set; }
    }
}
