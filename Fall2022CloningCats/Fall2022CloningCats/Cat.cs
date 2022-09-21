using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2022CloningCats
{
    internal class Cat : ICloneable, IEquatable<Cat>
    {
        public string Name { get; set; } 
        public int Age { get; set; }
        public bool IsFat { get; set; }
        public Owner Owner { get; set; }
        public Cat()
        {
            Name = "Dez";
            Age = 7;
            IsFat = true;
        }
        public Cat(string name, int age, bool isFat)
        {
            Name = name;
            Age = age;
            IsFat = isFat;
            
        }

        public object Clone()
        {
            return new Cat(this.Name, this.Age, this.IsFat);
        }

        public bool Equals(Cat? other)
        {
            if(other == null) return false;
            return this.Name == other.Name && this.Age == other.Age && this.IsFat == other.IsFat;
        }
    }
}
