using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPISample.Models;

namespace WebAPISample.Data
{
    public class WebAPISampleContext : DbContext
    {
        public WebAPISampleContext (DbContextOptions<WebAPISampleContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPISample.Models.Book> Book { get; set; }
    }
}
