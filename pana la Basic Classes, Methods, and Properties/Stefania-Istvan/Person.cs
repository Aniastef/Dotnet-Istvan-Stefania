using System;
using System.Collections.Generic;
using System.Text;

namespace Stefania_Istvan
{
    public class Person
    {
        //string _middleName = "Georgiana";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            { return FirstName + " " + LastName;
            }

        }

      

    }
}
