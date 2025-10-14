using Microsoft.EntityFrameworkCore;
using Entities.MetaModels;
using Entities.JsonModels;

namespace Entities.DbContext
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Core Models
        public DbSet<User> Users { get; set; }
        public DbSet<UserRoleMapping> UserRoleMappings { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobDraft> JobDrafts { get; set; }
        public DbSet<JobHistory> JobHistories { get; set; }
        public DbSet<SavedJob> SavedJobs { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationHistory> ApplicationHistories { get; set; }
        public DbSet<ScheduledInterview> ScheduledInterviews { get; set; }
        public DbSet<ScheduledInterviewHistory> ScheduledInterviewHistories { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        public DbSet<OrganisationTeam> OrganisationTeams { get; set; }
        public DbSet<OfficeLoc> OfficeLocs { get; set; }

        // Meta Models
        public DbSet<Role> Roles { get; set; }
        public DbSet<SubRole> SubRoles { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillsCategory> SkillsCategories { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<DegreeType> DegreeTypes { get; set; }
        public DbSet<DegreeStatus> DegreeStatuses { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<StatusCategories> StatusCategories { get; set; }
        public DbSet<OfficeType> OfficeTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<InterviewFormat> InterviewFormats { get; set; }
        public DbSet<WorkMode> WorkModes { get; set; }
        public DbSet<ExperienceLevel> ExperienceLevels { get; set; }
        public DbSet<PriorityLevel> PriorityLevels { get; set; }
        public DbSet<InterviewReschedulingReason> InterviewReschedulingReasons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure JSON/owned types and relationships here as needed
            base.OnModelCreating(modelBuilder);
        }
    }
}
