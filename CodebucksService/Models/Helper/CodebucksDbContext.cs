using Microsoft.EntityFrameworkCore;

namespace CodebucksService.Models.Helper
{
    public class CodebucksDbContext : DbContext
    {
        public CodebucksDbContext(DbContextOptions<CodebucksDbContext> contextOptions) : base(contextOptions)
        {
        }

        public DbSet<User> users { get; set; }
        public DbSet<Setting> settings { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Edu_Section> edu_Sections { get; set; }
        public DbSet<Edu_Progres> edu_Progress { get; set; }
        public DbSet<Edu_Lesson> edu_Lessons { get; set; }
        public DbSet<Edu_Enrollment> edu_Enrollments { get; set; }
        public DbSet<Edu_Categorie> edu_Categories { get; set; }
        public DbSet<Doc_Categorie> doc_categories { get; set; }
        public DbSet<Doc> docs { get; set; }
        public DbSet<Demo> demos { get; set; }
        public DbSet<Subscriber> subscribers { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Blog_post> blog_Posts { get; set; }
        public DbSet<Blog_comment> blog_Comments { get; set; }
        public DbSet<Blog_categorie> blog_Categories { get; set; }
        public DbSet<Blacklist> blacklists { get; set; }
        public DbSet<Audit_log> audit_Logs { get; set; }
    }
}