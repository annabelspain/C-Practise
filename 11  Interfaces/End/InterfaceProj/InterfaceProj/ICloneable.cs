using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProj
{
    public interface ICloneable<T>
    {
        T Clone();
    }
}
