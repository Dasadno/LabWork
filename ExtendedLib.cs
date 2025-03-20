using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExtendedLib
    {
        static public List<Book> GetAllBooksAfterYear(int year, ref Library<Book> lib)
        {
            var query = from book in lib.MediaList where book.YearPublished < year orderby book select book;
            return query.ToList();
        }

        static public List<Movie> GetFillmsByDur(int min, ref Library<Movie> list)
        {
            var query = from movie in list.MediaList where movie.DurationMin < min select movie;
            return query.ToList();
        }
    }
}
