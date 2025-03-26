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
     if (_dict.ContainsValue(item)) { throw new Exception("Item already exist"); }
         _dict.Add(item.Title, item);
         MediaList.Add(item);
 }
 public bool RemoveFromDictByTitle(string title)
 {
     ArgumentNullException.ThrowIfNull(title);
     return _dict.Remove(title);
 }

 public T FindInDictByTitle(string title)
 {
     ArgumentNullException.ThrowIfNull(title);
     T Val = _dict[title];
     return Val;
 }
 public bool Remove(string title)
 {
     ArgumentNullException.ThrowIfNull(title);
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
     ArgumentNullException.ThrowIfNull(title);
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
     ArgumentNullException.ThrowIfNull(year);
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
