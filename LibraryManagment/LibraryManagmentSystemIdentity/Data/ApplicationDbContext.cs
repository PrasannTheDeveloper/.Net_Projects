using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LibraryManagmentSystemIdentity.Models;
using System;

namespace LibraryManagmentSystemIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BooksModel> Books { get; set; }
        public DbSet<AuthorsModel> Authors { get; set; }
        public DbSet<CollegesModel> Colleges { get; set; }
        public DbSet<StudentsModel> Students { get; set; }
        public DbSet<StudentBooksModel> StudentBooks { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Define One-to-Many Relationship: Author -> Books
            modelBuilder.Entity<BooksModel>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            // ✅ Define One-to-Many Relationship: College -> Students
            modelBuilder.Entity<StudentsModel>()
                .HasOne(s => s.College)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.CollegeId);

            modelBuilder.Entity<StudentBooksModel>()
               .HasKey(sb => new { sb.StudentId, sb.BookId });

            modelBuilder.Entity<StudentBooksModel>()
                .HasOne(sb => sb.Student)
                .WithMany(s => s.StudentBooks)
                .HasForeignKey(sb => sb.StudentId);

            modelBuilder.Entity<StudentBooksModel>()
                .HasOne(sb => sb.Book)
                .WithMany(b => b.StudentBooks)
                .HasForeignKey(sb => sb.BookId);

            // ✅ Seed Authors
            modelBuilder.Entity<AuthorsModel>().HasData(
                new AuthorsModel { AuthorId = 1, AuthorName = "J.K. Rowling", BirthDate = new DateTime(1965, 7, 31), Bio = "Author of Harry Potter series" },
                new AuthorsModel { AuthorId = 2, AuthorName = "George Orwell", BirthDate = new DateTime(1903, 6, 25), DeadDate = new DateTime(1950, 1, 21), Bio = "Author of 1984 & Animal Farm" },
                new AuthorsModel { AuthorId = 3, AuthorName = "Mark Twain", BirthDate = new DateTime(1835, 11, 30), DeadDate = new DateTime(1910, 4, 21), Bio = "Author of Tom Sawyer" },
                new AuthorsModel { AuthorId = 4, AuthorName = "J.R.R. Tolkien", BirthDate = new DateTime(1892, 1, 3), DeadDate = new DateTime(1973, 9, 2), Bio = "Lord of the Rings" },
                new AuthorsModel { AuthorId = 5, AuthorName = "Stephen King", BirthDate = new DateTime(1947, 9, 21), Bio = "Horror fiction writer" },
                new AuthorsModel { AuthorId = 6, AuthorName = "Ernest Hemingway", BirthDate = new DateTime(1899, 7, 21), DeadDate = new DateTime(1961, 7, 2), Bio = "Author of The Old Man and The Sea" },
                new AuthorsModel { AuthorId = 7, AuthorName = "F. Scott Fitzgerald", BirthDate = new DateTime(1896, 9, 24), DeadDate = new DateTime(1940, 12, 21), Bio = "The Great Gatsby" },
                new AuthorsModel { AuthorId = 8, AuthorName = "Agatha Christie", BirthDate = new DateTime(1890, 9, 15), DeadDate = new DateTime(1976, 1, 12), Bio = "Queen of Crime" },
                new AuthorsModel { AuthorId = 9, AuthorName = "Leo Tolstoy", BirthDate = new DateTime(1828, 9, 9), DeadDate = new DateTime(1910, 11, 20), Bio = "War and Peace" },
                new AuthorsModel { AuthorId = 10, AuthorName = "Jane Austen", BirthDate = new DateTime(1775, 12, 16), DeadDate = new DateTime(1817, 7, 18), Bio = "Pride and Prejudice" }
            );

            // ✅ Seed Books
           

            // ✅ Seed Colleges
            modelBuilder.Entity<CollegesModel>().HasData(
                new CollegesModel { CollegeId = 1, CollegeName = "Harvard University", CollegeAddress = "Cambridge, MA", CollegeEmail = "info@harvard.edu" },
                new CollegesModel { CollegeId = 2, CollegeName = "MIT", CollegeAddress = "Cambridge, MA", CollegeEmail = "contact@mit.edu" },
                new CollegesModel { CollegeId = 3, CollegeName = "Stanford University", CollegeAddress = "Stanford, CA", CollegeEmail = "info@stanford.edu" },
                new CollegesModel { CollegeId = 4, CollegeName = "Oxford University", CollegeAddress = "Oxford, UK", CollegeEmail = "admin@ox.ac.uk" },
                new CollegesModel { CollegeId = 5, CollegeName = "Cambridge University", CollegeAddress = "Cambridge, UK", CollegeEmail = "info@cam.ac.uk" }
            );

            // ✅ Seed Books
            modelBuilder.Entity<BooksModel>().HasData(
                // Existing books
                new BooksModel { BookId = 1, BookName = "Harry Potter", Description = "Magic story", AuthorId = 1 },
                new BooksModel { BookId = 2, BookName = "1984", Description = "Dystopian fiction", AuthorId = 2 },
                new BooksModel { BookId = 3, BookName = "Animal Farm", Description = "Political satire", AuthorId = 2 },
                new BooksModel { BookId = 4, BookName = "The Hobbit", Description = "Fantasy novel", AuthorId = 4 },
                new BooksModel { BookId = 5, BookName = "The Shining", Description = "Horror story", AuthorId = 5 },
                new BooksModel { BookId = 6, BookName = "Murder on the Orient Express", Description = "Detective novel", AuthorId = 8 },
                new BooksModel { BookId = 7, BookName = "Pride and Prejudice", Description = "Romantic novel", AuthorId = 10 },
                new BooksModel { BookId = 8, BookName = "The Great Gatsby", Description = "American classic", AuthorId = 7 },
                new BooksModel { BookId = 9, BookName = "War and Peace", Description = "Historical fiction", AuthorId = 9 },
                new BooksModel { BookId = 10, BookName = "The Old Man and The Sea", Description = "Adventure novel", AuthorId = 6 },

                // New books
                new BooksModel { BookId = 11, BookName = "The Catcher in the Rye", Description = "Coming-of-age novel", AuthorId = 7 },
                new BooksModel { BookId = 12, BookName = "The Lord of the Rings", Description = "Epic high fantasy", AuthorId = 4 },
                new BooksModel { BookId = 13, BookName = "Brave New World", Description = "Dystopian science fiction", AuthorId = 2 },
                new BooksModel { BookId = 14, BookName = "Fahrenheit 451", Description = "Dystopian novel about censorship", AuthorId = 2 },
                new BooksModel { BookId = 15, BookName = "Dracula", Description = "Gothic horror", AuthorId = 5 },
                new BooksModel { BookId = 16, BookName = "Frankenstein", Description = "Gothic science fiction", AuthorId = 5 },
                new BooksModel { BookId = 17, BookName = "The Picture of Dorian Gray", Description = "Philosophical novel", AuthorId = 5 },
                new BooksModel { BookId = 18, BookName = "The Chronicles of Narnia", Description = "Fantasy novel series", AuthorId = 4 },
                new BooksModel { BookId = 19, BookName = "The Hitchhiker's Guide to the Galaxy", Description = "Comic science fiction", AuthorId = 2 },
                new BooksModel { BookId = 20, BookName = "Alice's Adventures in Wonderland", Description = "Fantasy novel", AuthorId = 1 },
                new BooksModel { BookId = 21, BookName = "Wuthering Heights", Description = "Gothic fiction", AuthorId = 10 },
                new BooksModel { BookId = 22, BookName = "Gone with the Wind", Description = "Historical fiction", AuthorId = 5 },
                new BooksModel { BookId = 23, BookName = "A Tale of Two Cities", Description = "Historical novel", AuthorId = 9 },
                new BooksModel { BookId = 24, BookName = "The Sun Also Rises", Description = "Modernist novel", AuthorId = 6 },
                new BooksModel { BookId = 25, BookName = "To Kill a Mockingbird", Description = "Southern Gothic fiction", AuthorId = 7 },
                new BooksModel { BookId = 26, BookName = "The Kite Runner", Description = "Historical fiction", AuthorId = 1 },
                new BooksModel { BookId = 27, BookName = "The Book Thief", Description = "Historical fiction", AuthorId = 8 },
                new BooksModel { BookId = 28, BookName = "Slaughterhouse-Five", Description = "Anti-war science fiction", AuthorId = 2 },
                new BooksModel { BookId = 29, BookName = "The Great Expectations", Description = "Victorian novel", AuthorId = 3 },
                new BooksModel { BookId = 30, BookName = "Moby-Dick", Description = "Epic sea adventure", AuthorId = 3 },
                new BooksModel { BookId = 31, BookName = "Les Misérables", Description = "Historical novel", AuthorId = 9 },
                new BooksModel { BookId = 32, BookName = "Catch-22", Description = "Satirical novel", AuthorId = 7 },
                new BooksModel { BookId = 33, BookName = "The Fault in Our Stars", Description = "Young adult novel", AuthorId = 1 },
                new BooksModel { BookId = 34, BookName = "The Alchemist", Description = "Philosophical fiction", AuthorId = 8 },
                new BooksModel { BookId = 35, BookName = "The Secret Garden", Description = "Children's novel", AuthorId = 4 },
                new BooksModel { BookId = 36, BookName = "The Godfather", Description = "Crime novel", AuthorId = 2 },
                new BooksModel { BookId = 37, BookName = "The Road", Description = "Post-apocalyptic novel", AuthorId = 6 },
                new BooksModel { BookId = 38, BookName = "Shogun", Description = "Historical novel", AuthorId = 5 },
                new BooksModel { BookId = 39, BookName = "The Handmaid's Tale", Description = "Dystopian novel", AuthorId = 2 },
                new BooksModel { BookId = 40, BookName = "The Girl on the Train", Description = "Psychological thriller", AuthorId = 1 }
            );


            // ✅ Seed Students
            // ✅ Seed Students (Extended to 30 students)
            modelBuilder.Entity<StudentsModel>().HasData(
                new StudentsModel { StudentId = 1, StudentName = "Alice Johnson", StudentAddress = "NYC", StudentEmail = "alice@email.com", StudentPhone = "1234567890", StudentAge = 21, CollegeId = 1 },
                new StudentsModel { StudentId = 2, StudentName = "Bob Smith", StudentAddress = "Boston", StudentEmail = "bob@email.com", StudentPhone = "9876543210", StudentAge = 22, CollegeId = 2 },
                new StudentsModel { StudentId = 3, StudentName = "Charlie Brown", StudentAddress = "Los Angeles", StudentEmail = "charlie@email.com", StudentPhone = "1122334455", StudentAge = 23, CollegeId = 3 },
                new StudentsModel { StudentId = 4, StudentName = "David Williams", StudentAddress = "Chicago", StudentEmail = "david@email.com", StudentPhone = "2233445566", StudentAge = 24, CollegeId = 4 },
                new StudentsModel { StudentId = 5, StudentName = "Emma Davis", StudentAddress = "Miami", StudentEmail = "emma@email.com", StudentPhone = "3344556677", StudentAge = 25, CollegeId = 5 },
                new StudentsModel { StudentId = 6, StudentName = "Fayla Clark", StudentAddress = "Seattle", StudentEmail = "fayla@email.com", StudentPhone = "4455667788", StudentAge = 26, CollegeId = 1 },
                new StudentsModel { StudentId = 7, StudentName = "George Martin", StudentAddress = "Dallas", StudentEmail = "george@email.com", StudentPhone = "5566778899", StudentAge = 27, CollegeId = 2 },
                new StudentsModel { StudentId = 8, StudentName = "Hannah Lee", StudentAddress = "San Francisco", StudentEmail = "hannah@email.com", StudentPhone = "6677889900", StudentAge = 28, CollegeId = 3 },
                new StudentsModel { StudentId = 9, StudentName = "Isaac Parker", StudentAddress = "Houston", StudentEmail = "isaac@email.com", StudentPhone = "7788990011", StudentAge = 29, CollegeId = 4 },
                new StudentsModel { StudentId = 10, StudentName = "Jessica Allen", StudentAddress = "Austin", StudentEmail = "jessica@email.com", StudentPhone = "8899001122", StudentAge = 30, CollegeId = 5 },
                new StudentsModel { StudentId = 11, StudentName = "Kevin Scott", StudentAddress = "Denver", StudentEmail = "kevin@email.com", StudentPhone = "9900112233", StudentAge = 21, CollegeId = 1 },
                new StudentsModel { StudentId = 12, StudentName = "Laura Walker", StudentAddress = "Philadelphia", StudentEmail = "laura@email.com", StudentPhone = "1011121314", StudentAge = 22, CollegeId = 2 },
                new StudentsModel { StudentId = 13, StudentName = "Matthew Hall", StudentAddress = "Phoenix", StudentEmail = "matthew@email.com", StudentPhone = "1213141516", StudentAge = 23, CollegeId = 3 },
                new StudentsModel { StudentId = 14, StudentName = "Nancy Allen", StudentAddress = "Boston", StudentEmail = "nancy@email.com", StudentPhone = "1415161718", StudentAge = 24, CollegeId = 4 },
                new StudentsModel { StudentId = 15, StudentName = "Oliver Young", StudentAddress = "Chicago", StudentEmail = "oliver@email.com", StudentPhone = "1617181920", StudentAge = 25, CollegeId = 5 },
                new StudentsModel { StudentId = 16, StudentName = "Paul Harris", StudentAddress = "Seattle", StudentEmail = "paul@email.com", StudentPhone = "1819202122", StudentAge = 26, CollegeId = 1 },
                new StudentsModel { StudentId = 17, StudentName = "Quincy Lee", StudentAddress = "Los Angeles", StudentEmail = "quincy@email.com", StudentPhone = "2021222324", StudentAge = 27, CollegeId = 2 },
                new StudentsModel { StudentId = 18, StudentName = "Rachel Nelson", StudentAddress = "San Francisco", StudentEmail = "rachel@email.com", StudentPhone = "2223242526", StudentAge = 28, CollegeId = 3 },
                new StudentsModel { StudentId = 19, StudentName = "Samuel Green", StudentAddress = "Houston", StudentEmail = "samuel@email.com", StudentPhone = "2425262728", StudentAge = 29, CollegeId = 4 },
                new StudentsModel { StudentId = 20, StudentName = "Tina Carter", StudentAddress = "Dallas", StudentEmail = "tina@email.com", StudentPhone = "2627282930", StudentAge = 30, CollegeId = 5 },
                new StudentsModel { StudentId = 21, StudentName = "Ursula King", StudentAddress = "Phoenix", StudentEmail = "ursula@email.com", StudentPhone = "2829303132", StudentAge = 21, CollegeId = 1 },
                new StudentsModel { StudentId = 22, StudentName = "Victor Adams", StudentAddress = "Miami", StudentEmail = "victor@email.com", StudentPhone = "3031323334", StudentAge = 22, CollegeId = 2 },
                new StudentsModel { StudentId = 23, StudentName = "Wendy Turner", StudentAddress = "Austin", StudentEmail = "wendy@email.com", StudentPhone = "3233343536", StudentAge = 23, CollegeId = 3 },
                new StudentsModel { StudentId = 24, StudentName = "Xander Morris", StudentAddress = "Philadelphia", StudentEmail = "xander@email.com", StudentPhone = "3435363738", StudentAge = 24, CollegeId = 4 },
                new StudentsModel { StudentId = 25, StudentName = "Yara Phillips", StudentAddress = "San Francisco", StudentEmail = "yara@email.com", StudentPhone = "3637383940", StudentAge = 25, CollegeId = 5 },
                new StudentsModel { StudentId = 26, StudentName = "Zane Harris", StudentAddress = "New York", StudentEmail = "zane@email.com", StudentPhone = "3839404142", StudentAge = 26, CollegeId = 1 },
                new StudentsModel { StudentId = 27, StudentName = "Amy Jenkins", StudentAddress = "Los Angeles", StudentEmail = "amy@email.com", StudentPhone = "4041424344", StudentAge = 27, CollegeId = 2 },
                new StudentsModel { StudentId = 28, StudentName = "Brandon Turner", StudentAddress = "Chicago", StudentEmail = "brandon@email.com", StudentPhone = "4243444546", StudentAge = 28, CollegeId = 3 },
                new StudentsModel { StudentId = 29, StudentName = "Christina Miller", StudentAddress = "Boston", StudentEmail = "christina@email.com", StudentPhone = "4445464748", StudentAge = 29, CollegeId = 4 },
                new StudentsModel { StudentId = 30, StudentName = "Dylan Evans", StudentAddress = "Seattle", StudentEmail = "dylan@email.com", StudentPhone = "4647484950", StudentAge = 30, CollegeId = 5 }
            );

            



        }
    }
}
