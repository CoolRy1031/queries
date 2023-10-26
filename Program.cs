// See https://aka.ms/new-console-template for more information
namespace Queries 
{
  class Program
  {
    static void Main(string[] args)
    {
      var movies = new List<Movie>
      {
        new Movie {Title = "Dark Knight", Rating = 8.9f, Year = 2008},
        new Movie {Title = "The Kings Speech", Rating = 8.0f, Year = 2010},
        new Movie {Title = "Casablanca", Rating = 8.5f, Year = 1932},
        new Movie {Title = "Star Wars 5", Rating = 8.7f, Year = 1980}

      };
      var query = movies.Where(m => m.Year > 2000).OrderByDescending(m => m.Rating);
      Console.WriteLine(query.Count());
      // var enumerator = query.GetEnumerator();
      // while ( enumerator.MoveNext())
      // {
      //   Console.WriteLine(enumerator.Current.Title);
      // }
    }
  }
}