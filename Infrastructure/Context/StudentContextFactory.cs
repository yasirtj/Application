using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Context
{
    public class StudentContextFactory : IDesignTimeDbContextFactory<StudentDbContext>
    {
        public StudentDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentDbContext>();
            var connectionString = "Data Source=(localdb)\\MsSqlLocalDb;initial catalog=StudentDb;Integrated Security=True; MultipleActiveResultSets=True";
            optionsBuilder.UseSqlServer(connectionString);
            return new StudentDbContext(optionsBuilder.Options);
        }
    }
}
