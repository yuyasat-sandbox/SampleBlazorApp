using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleBlazorApp.Models;

public class SampleBlazorAppContext : DbContext
{
    public SampleBlazorAppContext(DbContextOptions<SampleBlazorAppContext> options)
        : base(options)
    {
    }

    public DbSet<Person> Person { get; set; } = default!;
}
