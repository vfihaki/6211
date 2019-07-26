using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Teacher : Person
    {
        public string Login { get; set; }
        public Teacher(string name,int age, string login)
        {
            Name = name;
            Age = age;
            Login = login;
        }
    }

}
