using System;

namespace Syntax3
{
    public struct Car
    {
        
        public static bool Start()
        {
            if (this != null)
                return true;
            else
                return false;
        

          //  return this != null;
        }
    }
}