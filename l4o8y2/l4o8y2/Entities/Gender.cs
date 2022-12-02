using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4o8y2.Entities
{
    public enum Gender
    {
        Male = 1,
        Female = 2
    }
    Gender ádámNeme = Gender.Male;
    Gender évaNeme = (Gender)2;

if (ádámNeme == Gender.Male)
{
    ...
}
}
