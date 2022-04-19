using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProj
{
    public interface ITaxRules
    {
        double VAT { get; }
        decimal RegionalTax { get; }
    }
}
