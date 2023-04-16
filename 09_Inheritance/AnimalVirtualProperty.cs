using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Inheritance
{
    internal class AnimalVirtualProperty
    {
        public string Animal { get; set; }
        public virtual string Sound { get; set; }        
    }
}