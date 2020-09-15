using System.Collections.Generic;
using CmdSnippetsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CmdSnippetsAPI.Database
{
    public class CmdSnippetsAPIContext : DbContext
    {
        public CmdSnippetsAPIContext(DbContextOptions<CmdSnippetsAPIContext> opt)
            : base(opt)
        {}

        public DbSet<Command> Commands { get; set; }
    }
}