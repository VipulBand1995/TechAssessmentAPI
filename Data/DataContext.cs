using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }

        public DbSet<TblTeamName> Team_Profile { get; set;}
        public DbSet<T_Score> T_Score { get; set;}

        public DbSet<MatchDetails> Match_Details { get; set;}

        public DbSet<PlayerProfile> Player_Profile { get; set;} 

        public DbSet<TblVenue> tbl_Venue { get; set;}

        public DbSet<TblStudentDetails> tbl_StudentDetails { get; set;}

    }
}