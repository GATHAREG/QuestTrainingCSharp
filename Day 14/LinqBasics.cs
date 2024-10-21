using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public int Age {  get; set; }

        //public override string ToString()
        //{
        //   return;

        //}

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var data = new int[] { 1, 2, 3, 4, 5, 6, 12, 18, 20, 21 };
            //var res = data.Skip(3)
            //    .Take(5)
            //    .Where(x => x % 2 == 0)
            //    .Sum();
            //var r = data.First();
            //var rs = data.FirstOrDefault();
            //var sorted = data.OrderBy(x => x);
            //var sortedDescending = data.OrderByDescending(x => x);
            //var min = data.Min();
            //var max = data.Max();
            //var count = data.Count();
            //var minGreaterThanfive = data.Min(x => x > 5);
            //var takeWhile = data.TakeWhile(i => i < 5);
            //var skipWhile = data .SkipWhile(i => i < 5);
            //Console.WriteLine(string.Join("",sorted));
            //Console.WriteLine(string.Join("", sortedDescending));
            //Console.WriteLine(string.Join("", minGreaterThanfive));
            //Console.WriteLine(string.Join("", takeWhile));
            //Console.WriteLine(string.Join("", skipWhile));
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            //Console.WriteLine(count);

            var data = new List<Person>()
             {
              new Person{Name="Person 1", Country="US", Age=20},
              new Person{Name="Person 2", Country="US", Age=30},
              new Person{Name="Person 3", Country="US", Age=40},
              new Person{Name="Person 4", Country="IN", Age=50}
             };

            var res = data.Where(p => p.Country == "US");

            //foreach (var person in res)
            //{
            //    Console.WriteLine(person.Name);
            //}
            var minAge = data.Where(p =>p.Country == "US").Min(p => p.Age);

            var personp = data.Where(p => p.Country == "US"  &&  p.Age == minAge).FirstOrDefault();

            //var sorted = data.OrderByDescending(p => p.Age);
            //foreach (var person in sorted)
            //{
            //    Console.WriteLine(person.Name);
            //}
            var distinctCountries = data.Select(p => p.Country).Distinct();
            //select
            var countries = data.Select(p => new Dictionary<string, string>()
            {
                { "Name", p.Name },
                { "Country", p.Country }
            });

            //GroupBy
            var groups = data.GroupBy(p => p.Country);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
                foreach (var person in group)
                {
                    Console.WriteLine($"\t{person.Name}");
                }
            }



        }
    }
}
