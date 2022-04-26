using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkScheduleSolution.Entities;
using Microsoft.EntityFrameworkCore;


namespace WorkScheduleSolution.Data
{
    public class WorkScheduleContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills{ get; set; }
        public DbSet<EmployeeSkill> EmployeesSkills { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PlacementContract> PlacementsContract { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-47CLFBT;Database=WorkSchedule;User Id=sa;Password=D@gisik@n1997*");
            }
        }
    }

}
