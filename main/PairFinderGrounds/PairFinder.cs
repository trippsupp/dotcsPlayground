using System;
using System.Collections.Generic;

namespace PairFinderGrounds
{

    /// <summary>
    /// Represents the class for the PairFinder grounds.
    /// </summary>
    public class PairFinder
    {
        // the first list of ints to cross-check
        private readonly int[] _i2 = { 0, 2, 33, 6, 8, 10 };
        // the second list of ints to cross-check
        private readonly int[] _i1 = { 0, 3, 10, 15, 20, 25 };
        // the target that Pair().Verify() must satisy
        private const int _target = 40;
        // the pairs to be verified
        private List<Pair> _pairs = null;

        /// <summary>
        /// Starts the PairFinder grounds.
        /// </summary>
        public void Start()
        {
            System.Console.WriteLine("Starting PairFinder grounds...");
            System.Console.WriteLine("");
            System.Console.WriteLine("Array 1  = " + PrintIntArr(_i1));
            System.Console.WriteLine("Array 2  = " + PrintIntArr(_i2));
            System.Console.WriteLine("Target   = " + _target);
            System.Console.WriteLine("");

            // looking for pairs that equal the given target
            _pairs = CreatePairsBasedOnTarget(_i1, _i2, _target);

            // display all valid pairs
            DisplayPairs(_pairs);

            // re-verify all valid pairs
            if (VerifyPairs(_pairs) )
            {
                System.Console.WriteLine("All pairs re-verified.");
            }
            else
            {
                System.Console.WriteLine("One or more pairs invalidated.");
            }
        }

        /// <summary>
        /// Returns whether the given list of pairs is valid.
        /// A pair is considered valid if (pair.X * pair.Y == pair.Target).
        /// </summary>
        /// <param name="pairs">A list of pairs.</param>
        /// <returns>True if the given list contains only valid pairs, else if not.</returns>
        private bool VerifyPairs(List<Pair> pairs)
        {            
            foreach(Pair p in pairs)
            {
                if (!p.Verify())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Prints the given list of pairs.
        /// </summary>
        /// <param name="pairs">A list of pairs.</param>
        private void DisplayPairs(List<Pair> pairs)
        {
            if (!ReferenceEquals(null, pairs))
            {
                if (pairs.Count > 0)
                {
                    System.Console.WriteLine(pairs.Count + " valid pairs have been found");
                    foreach (Pair p in pairs)
                    {
                        System.Console.WriteLine(p.ToString()); // display each valid pair
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Pairs list is null."); // shouldn't happen
            }
        }

        /// <summary>
        /// Returns the given integer array as a string.
        /// </summary>
        /// <param name="arr">An array of integers.</param>
        /// <returns></returns>
        private string PrintIntArr(int[] arr)
        {
            string s = "{ ";
            for(int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    s += arr[i] + " }";
                }
                else
                {
                    s += arr[i] + ", ";
                }
            }
            return s;
        }

        /// <summary>
        /// Returns a list of new valid pairs based off of the given target. 
        /// <para>A Pair is created if a number in the first given integer array
        /// multiplys with a number in the second given integer array
        /// to equal the given target integer.</para>
        /// 
        /// </summary>
        /// <param name="i1">An array of integers</param>
        /// <param name="i2">An array of integers</param>
        /// <param name="target">The given target</param>
        /// <returns>A list of valid pairs based on the given target.</returns>
        private List<Pair> CreatePairsBasedOnTarget(int[] i1, int[] i2, int target)
        {
            List<Pair> pairsFound = null;

            if ( ReferenceEquals(null, i1) || ReferenceEquals(null, i1) || ReferenceEquals(null, i1) )
            {
                return pairsFound;
            }
            else
            {
                pairsFound = new List<Pair>();
                
                HashSet<int> set = new HashSet<int>(i1);
                for(int i = 0; i < i2.Length; i++)
                {
                    if (i2[i] != 0 && set.Contains(target / i2[i]))
                    {
                        // target found                        
                        pairsFound.Add(new Pair { X = (target / i2[i]), Y = i2[i], Target = target });
                    }
                }
                return pairsFound;
            }
                // Brute force:
                //for(int x = 0; x < i1.Length; x++)
                //{
                //    for(int y = 0; y < i2.Length; y++)
                //    {
                //        if ( i1[x] * i2[y] == target )
                //        {
                //            // target found 
                //            pairsFound.Add( new Pair { X = i1[x], Y = i2[y], Target = target } );
                //        }
                //    } // for y
                //} // for x



        }
    }
    
}
