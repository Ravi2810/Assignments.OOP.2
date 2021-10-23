using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InvalidSubsequence()
        {
            var seq = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var subseq = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            int m = seq.Count;
            int n = subseq.Count;
            bool res = IsValidSubsequeuce(seq, subseq, m, n);

            if (res)
                Console.Write("Yes");
            else
                Console.Write("No");


        }

        private bool IsValidSubsequeuce(List<int> seq, List<int> subseq, int m, int n)
        {
            throw new NotImplementedException();
        }
    }
}
