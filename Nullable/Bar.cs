using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    public struct Bar
    {
        public Bar(int number)
        {
            Number = number;
        }
        public int Number { get; private set; }
    }
}
