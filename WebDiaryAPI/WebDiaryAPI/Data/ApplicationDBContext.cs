using Microsoft.EntityFrameworkCore;
using WebDiaryAPI.Models;

namespace WebDiaryAPI.Data
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
		{
			
		}

		public DbSet<DiaryEntry> DiaryEntries { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<DiaryEntry>().HasData(
				new DiaryEntry { Id = 1, Title = "Went Hiking", Content = "Went hiking with Joe!", Created = new DateTime(2026, 4, 18, 13, 9, 29, 41, DateTimeKind.Local).AddTicks(4264) },
				new DiaryEntry { Id = 2, Title = "Went Shoping", Content = "Went shoping with Joe!", Created = new DateTime(2026, 4, 18, 13, 9, 29, 41, DateTimeKind.Local).AddTicks(4391) },
				new DiaryEntry { Id = 3, Title = "Went Diving", Content = "Went diving with Joe!", Created = new DateTime(2026, 4, 18, 13, 9, 29, 41, DateTimeKind.Local).AddTicks(4395) }
			);
		}
	}
}
