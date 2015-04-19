using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraveyardCalculator
{
    public class Role
    {
        public string Name { get; set; }
        public Boolean IsUnique { get; set; }
        public List<string> Categories { get; set; }
        public Boolean ExactMatch(string s)
        {
            return (s == Name);
        }
        public Boolean CategoryMatch(string s)
        {
            return Categories.Contains(s);
        }
    }
}
