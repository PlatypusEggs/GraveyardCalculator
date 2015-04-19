using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardCalculator
{
    public static class Roles
    {
        public static List<Role> ListRoles;
        static Roles()
        {
            ListRoles = new List<Role>();

            ListRoles.Add(new Role { Name = "Bodyguard", IsUnique = false, Categories = new List<string> { "Town Protective", "Town Killing"} });
            ListRoles.Add(new Role { Name = "Bus Driver", IsUnique = false, Categories = new List<string> { "Town Protective", "Town Power" } });
            ListRoles.Add(new Role { Name = "Citizen", IsUnique = false, Categories = new List<string> { "Town Government" } });
            ListRoles.Add(new Role { Name = "Coroner", IsUnique = false, Categories = new List<string> { "Town Government" } });
            ListRoles.Add(new Role { Name = "Crier", IsUnique = true, Categories = new List<string> { "Town Government" } });
            ListRoles.Add(new Role { Name = "Detective", IsUnique = false, Categories = new List<string> { "Town Investigative" } });
            ListRoles.Add(new Role { Name = "Doctor", IsUnique = false, Categories = new List<string> { "Town Protective" } });
            ListRoles.Add(new Role { Name = "Escort", IsUnique = false, Categories = new List<string> { "Town Protective" } });
            ListRoles.Add(new Role { Name = "Investigator", IsUnique = false, Categories = new List<string> { "Town Investigative" } });
            ListRoles.Add(new Role { Name = "Jailor", IsUnique = false, Categories = new List<string> { "Town Killing", "Town Power" } });
            ListRoles.Add(new Role { Name = "Lookout", IsUnique = false, Categories = new List<string> { "Town Investigative" } });
            ListRoles.Add(new Role { Name = "Marshall", IsUnique = true, Categories = new List<string> { "Town Government" } });
            ListRoles.Add(new Role { Name = "Mason", IsUnique = false, Categories = new List<string> { "Town Government" } });
            ListRoles.Add(new Role { Name = "Mason Leader", IsUnique = true, Categories = new List<string> { "Town Government" } });
            ListRoles.Add(new Role { Name = "Mayor", IsUnique = true, Categories = new List<string> { "Town Government" } });
            ListRoles.Add(new Role { Name = "Sheriff", IsUnique = false, Categories = new List<string> { "Town Investigative" } });
            ListRoles.Add(new Role { Name = "Spy", IsUnique = false, Categories = new List<string> { "Town Power" } });
            ListRoles.Add(new Role { Name = "Stump", IsUnique = false, Categories = new List<string> { } });
            ListRoles.Add(new Role { Name = "Veteran", IsUnique = false, Categories = new List<string> { "Town Killing", "Town Power" } });
            ListRoles.Add(new Role { Name = "Vigilante", IsUnique = false, Categories = new List<string> { "Town Killing" } });
        }
    }
}
