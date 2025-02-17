using Microsoft.EntityFrameworkCore;

namespace Next2_BlazorServerApplication.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options) { }

		public DbSet<Question> Questions { get; set; }
		public DbSet<Answer> Answers { get; set; }
        public DbSet<User> Users { get; set; }
    }


}
public class Question
{
    public int QuestionID { get; set; }
    public string QuestionText { get; set; }
    public int? ParentQuestionID { get; set; }
    public string Category { get; set; }
    public List<Answer> Answers { get; set; }
}

public class Answer
{
    public int AnswerID { get; set; }
    public int QuestionID { get; set; }
    public string AnswerText { get; set; }
    public int? NextQuestionID { get; set; }
}

public class User
{
    public int userID { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public string PasswordHash { get; set; }
}