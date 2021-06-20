using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    class Tuple<TFirst, TSecond>
    {
        public Tuple(TFirst firstEl, TSecond secondEl)
        {
            FirstElement = firstEl;
            SecondElement = secondEl;
        }
        public TFirst FirstElement { get; }
        public TSecond SecondElement { get; }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
