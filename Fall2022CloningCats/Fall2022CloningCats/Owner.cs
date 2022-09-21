using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022CloningCats
{
    internal class Owner
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Owner()
        {
            Name = "Davis";
            Age = 24;
        }
        public Owner(string name,int age)
        {
            Name = name;
            Age = age;
        }   
    }

    
}
