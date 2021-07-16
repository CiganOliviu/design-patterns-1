using System;
using System.Collections.Generic;

namespace IteratorPattern
{

    internal class Companies
    {
        public static IEnumerable<string> GetCompanies()
        {
            var companies = new List<string>() {"3SS", "Google", "Apple"};
            
            foreach (var company in companies)
                yield return company;
        }
    }
    
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var companies = Companies.GetCompanies();

            foreach (var company in companies)
                Console.WriteLine(company);
        }
    }
}