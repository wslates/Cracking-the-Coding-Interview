using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckPermutation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPermutation.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TwoLowerCasePermutations()
        {   
            //test if lower case works
            string str1 = "wesley";
            string str2 = "eswely";

            Assert.AreEqual(true, Program.IsPermutation(str1, str2));

        }
        [TestMethod()]
        public void TwoMixedCasePermutations()
        {
            //test if mixed case works
            string str1 = "WeSlEy";
            string str2 = "EsweLY";
            Assert.AreEqual(true, Program.IsPermutation(str1, str2));
        }

        [TestMethod()]
        public void TwoNonPermutations()
        {
            //test if mixed case works
            string str1 = "cat";
            string str2 = "car";
            Assert.AreEqual(false, Program.IsPermutation(str1, str2));
        }

        [TestMethod()]
        public void DifferentSizeStrings()
        {
            //test if mixed case works
            string str1 = "cat";
            string str2 = "catt";
            Assert.AreEqual(false, Program.IsPermutation(str1, str2));
        }
    }
}