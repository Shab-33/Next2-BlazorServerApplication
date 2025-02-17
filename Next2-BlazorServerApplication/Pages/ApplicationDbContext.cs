using Microsoft.EntityFrameworkCore;

namespace Next2_BlazorServerApplication.Pages
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
		: base(options) { }

		public DbSet<Question> Questions { get; set; }
		public DbSet<Answer> Answers { get; set; }
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