using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PlataformaEnLinea.Models
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseModule> CourseModules { get; set; }
        public DbSet<ContentType> ContentTypes { get; set; }
        public DbSet<CourseMaterial> CourseMaterials { get; set; }
        public DbSet<CourseEnrollment> CourseEnrollments { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<QuestionType> QuestionTypes { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<ExamOption> ExamOptions { get; set; }
        public DbSet<ExamSubmission> ExamSubmissions { get; set; }
        public DbSet<ExamAnswer> ExamAnswers { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<PaymentOption> PaymentOptions { get; set; }
        public DbSet<CoursePricing> CoursePricings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<DiscussionForum> DiscussionForums { get; set; }
        public DbSet<DiscussionPost> DiscussionPosts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LocalizedContent> LocalizedContents { get; set; }
        public DbSet<CourseSubscription> CourseSubscriptions { get; set; }

    }
}
