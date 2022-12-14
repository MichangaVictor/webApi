using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class DonationDBContext:DbContext
    {
        public DonationDBContext(DbContextOptions<DonationDBContext> options):base(options)
        {
                
        }
        public DbSet<DCandidate>DCandidates { get; set; }
        public DbSet<Student> students { get; set; }

    } 
}
