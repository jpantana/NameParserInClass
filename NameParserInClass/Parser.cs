using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameParserInClass
{
    public class Parser
    {
        public Name ParseName(string nameToParse)
        {
            var splitNames = nameToParse.Split(" ");
            var name = new Name();
            name.FirstName = splitNames.First();
            name.LastName = splitNames.Last();

            return name;
        }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
