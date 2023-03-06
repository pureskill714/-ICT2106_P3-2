using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YouthActionM3.Models;

namespace YouthActionM3.Data
{
    public class YouthActionM3Context : DbContext
    {
        public YouthActionM3Context (DbContextOptions<YouthActionM3Context> options)
            : base(options)
        {
        }

        public DbSet<YouthActionM3.Models.ServiceCentre> ServiceCentre { get; set; } = default!;
    }
}
