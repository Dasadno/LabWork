using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Library<T> : IMediaManager<T> where T : Media
    {
        public List<T> MediaList { get { return _list; } }

        private Dictionary<string, T>  _dict = new Dictionary<string, T>();

        private List<T> _list = new List<T>();

        public void Add(T item)
        {
            try
            {
                MediaList.Add(item);
            }
            catch (Exception)
            {

                throw new Exception("Item already exist");
            }
            
        }
        public bool Remove(string title)
        {
            if (title == null) throw new ArgumentNullException("argument can't be null");
            foreach (var item in MediaList)
            {
                if (item.Title == title)
                {
                    MediaList.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public T FindByTitle(string title)
        {
            if (title == null) throw new ArgumentNullException("argument can't be null");
            foreach (var item in MediaList)
            {
                if (item.Title == title)
                {
                    return item;
                }
            }
            return null;
        }

        public IEnumerable<T> FilterByYear(int year)
        {
            if (year == null) throw new ArgumentNullException("argument can't be null");
            List<T> li = new List<T>();

            foreach (var item in MediaList)
            {
                if (item.YearPublished == year)
                {
                    li.Add(item);
                }
            }
            return li;
        }

        public IEnumerable<T> GetAllAvailable()
        {
            List<T> li = new List<T>();
            foreach (var item in MediaList)
            {
                if (item.IsAvailable)
                {
                    li.Add(item);
                }
            }
            return li;
        }
        public IEnumerable<T> GetAllUnavailable()
        {
            var query = from item in MediaList where !item.IsAvailable select item;
            return query.ToList();
        }

        public void PrintAll()
        {
            foreach (var item in MediaList)
            {
                Console.WriteLine($"Title: {item.Title},\nAvailable: {item.IsAvailable},\nYear published: {item.YearPublished}\n\n");
            }
        }
        
    }
}
