using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using EntitiesLayer;

public class SportsClubContext : DbContext
{
    public DbSet<Member> Members { get; set; }
    public DbSet<Equipment> Equipment { get; set; }
    public DbSet<TrainingSession> TrainingSessions { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    public DbSet<Loan> Loans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("Server=sqlutb2-db.hb.se,56077;Database=YourDatabaseName;User Id=oosu2515;Password=FNC385;");
    }

}
