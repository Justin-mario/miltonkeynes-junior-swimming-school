using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MKJSS.Models;

namespace MKJSS.Data
{
    public class MKJSSContext : DbContext
    {
        public MKJSSContext (DbContextOptions<MKJSSContext> options)
            : base(options)
        {
        }

        public DbSet<MKJSS.Models.Booking> Booking { get; set; } = default!;
        public DbSet<MKJSS.Models.Coach> Coach { get; set; } = default!;
        public DbSet<MKJSS.Models.Learner> Learner { get; set; } = default!;
        public DbSet<MKJSS.Models.Lesson> Lesson { get; set; } = default!;
        public DbSet<MKJSS.Models.Review> Review { get; set; } = default!;
    }
}
