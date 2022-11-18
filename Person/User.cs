using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
     public class User
    {

        public User(string name, int age, double height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }

        public string name { get; set; }
        public int age { get; set; }
        public double height { get; set; }
    }
}
