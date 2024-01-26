using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasche
{
    public class Schoolbag
    {
        List<string> _things = new();

        string _color;

        public void Add(string thing)
        {
            _things.Add(thing);
        }
        public Schoolbag(string color)
        {
            _color = color;
        }
        public void Print()
        {
            for (int i = 0; i < _things.Count; i++)
            {
                if (_things[i].Substring(0,1) == "W")
                {
                    Console.WriteLine(_things[i]);
                }
            }
        }
    }
}
