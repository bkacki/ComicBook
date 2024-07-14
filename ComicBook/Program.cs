namespace ComicBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Comic> mostExpensive =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select comic;

            foreach(Comic item in mostExpensive)
                Console.WriteLine($"{item} jest wart {Comic.Prices[item.Issue]:c}");

            Console.WriteLine();

            IEnumerable<string> mostExpensiveComicDescription =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select $"{comic} jest wart {Comic.Prices[comic.Issue]:c}";

            foreach (string item in mostExpensiveComicDescription)
                Console.WriteLine(item);

            Console.WriteLine();

            var mostExpensiveVar =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select comic;

            foreach(Comic item in mostExpensiveVar)
                Console.WriteLine($"{item} jest wart {Comic.Prices[item.Issue]:c}");
        }
    }
}
