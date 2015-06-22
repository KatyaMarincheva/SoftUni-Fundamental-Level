using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Humans.Interfaces
{
    public interface IHuman
    {
       string FirstName { get; set; }
       string LastName { get; set; }

       string ToString();
    }
}
