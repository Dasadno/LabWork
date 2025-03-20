namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library<Media> lib = new Library<Media>();
            lib.MediaList.Add(new Media() { Author = "Author1", Title = "Title1", YearPublished = 1987, IsAvailable = true });
            lib.MediaList.Add(new Media() { Author = "Author2", Title = "Title2", YearPublished = 2005, IsAvailable = false });
            lib.MediaList.Add(new Media() { Author = "Author2", Title = "Title3", YearPublished = 2008, IsAvailable = true });
            lib.MediaList.Add(new Media() { Author = "Author3", Title = "Title3", YearPublished = 2008, IsAvailable = false });
            lib.MediaList.Add(new Media() { Author = "Author3", Title = "Title8", YearPublished = 1995, IsAvailable = true });
            lib.MediaList.Add(new Media() { Author = "Author4", Title = "Title5", YearPublished = 2015, IsAvailable = false });
            lib.MediaList.Add(new Media() { Author = "Author5", Title = "Title6", YearPublished = 2002, IsAvailable = false });
           
            lib.PrintAll();
        }
    }
}
