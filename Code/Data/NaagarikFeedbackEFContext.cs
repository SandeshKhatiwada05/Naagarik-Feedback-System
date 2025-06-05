using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NaagarikFeedbackEF.Models;

namespace NaagarikFeedbackEF.Data
{
    public class NaagarikFeedbackEFContext : DbContext
    {
        public NaagarikFeedbackEFContext (DbContextOptions<NaagarikFeedbackEFContext> options)
            : base(options)
        {
        }

        public DbSet<NaagarikFeedbackEF.Models.Feedback> Feedback { get; set; } = default!;
    }
}
