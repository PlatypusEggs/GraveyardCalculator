using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardCalculator
{
    public static class Categories
    {
        public static List<Category> ListCategories;
        static Categories()
        {
            ListCategories = new List<Category>();

            ListCategories.Add(new Category { Name = "Town Government", Roles = new List<string> { "Citizen", "Crier", "Marshall", "Mason", "Mason Leader", "Mayor" } });
            ListCategories.Add(new Category { Name = "Town Investigative", Roles = new List<string> { "Coroner", "Detective", "Investigator", "Lookout", "Sheriff" } });
            ListCategories.Add(new Category { Name = "Town Killing", Roles = new List<string> { "Bodyguard", "Jailor", "Veteran", "Vigilante" } });
            ListCategories.Add(new Category { Name = "Town Power", Roles = new List<string> { "Bus Driver", "Jailor", "Spy", "Veteran" } });
            ListCategories.Add(new Category { Name = "Town Protective", Roles = new List<string> { "Bodyguard", "Bus Driver", "Doctor", "Escort" } });
        }
    }
}
