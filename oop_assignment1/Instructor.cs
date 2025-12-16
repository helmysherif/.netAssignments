using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment1
{
    internal class Instructor(int instructorId, string name , string specialization)
    {
        public int instructorId = instructorId;
        public string name = name;
        public string specialization = specialization;
        public string PrintDetails()
        {
            return $"instructor name is {this.name} and his id is {instructorId} and his specialization is {specialization}";
        }
    }
}
