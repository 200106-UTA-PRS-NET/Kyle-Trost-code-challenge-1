using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using PalindromeLib;

namespace PalindromeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine($"one two one: {PalindromeChecker.IsPalindrome("one two one")}");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine($"123abccba123: {PalindromeChecker.IsPalindrome("123abccba123")}");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Console.WriteLine($"nurses run: {PalindromeChecker.IsPalindrome("nurses run")}");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Console.WriteLine($"racecaR: {PalindromeChecker.IsPalindrome("racecaR")}");
        }

        [TestMethod]
        public void TestMethod5()
        {
            Console.WriteLine($"1221: {PalindromeChecker.IsPalindrome("1221")}");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Console.WriteLine($"never odd, or even: {PalindromeChecker.IsPalindrome("never odd, or even")}");
        }
    }
}
