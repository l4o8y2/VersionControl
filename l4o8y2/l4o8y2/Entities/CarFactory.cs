using l4o8y2.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4o8y2.Entities
{
    public class CarFactory: IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }
    }
}
