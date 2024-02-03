using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moment4_webbapi.Models;

public class MusicContext : DbContext
{
    public MusicContext(DbContextOptions<MusicContext> options)
        : base(options)
    {
    }

    public DbSet<Music> Music { get; set; } = default!;

}
