using Microsoft.EntityFrameworkCore;

namespace SIGMA.Models
{
    public class CandidateContext : DbContext
    {
        public CandidateContext(DbContextOptions options): base(options){ }

        public DbSet<Candidate> Candidate { get; set; }
    }
}
