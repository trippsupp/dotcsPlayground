using System;
using System.Collections.Generic;
using System.Text;

namespace PairFinderGrounds
{
    /// <summary>
    /// A Pair represents two integers (`X` & `Y`) whose product equals a given integer (`target`)
    /// `X` * `Y` == `target`
    /// Examples of Pair:
    ///     new Pair(4, 20);
    ///     new Pair(-77, 444);
    ///     new Pair(0, 1);
    /// </summary>
    public class Pair
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Target { get; set; }

        public bool Verify()
        {
            return (Target == (X * Y));
        }

        public override string ToString()
        {
            return "Pair(" + X + ", " + Y + ")";
        }

    }
}
