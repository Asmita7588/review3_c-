using System.Runtime.CompilerServices;
using review3;

namespace TestProject1
{
    public class Tests
    {
        private Calculator calculator;
        private PalindromeStr palindrome;
        [SetUp]
        public void Setup()
        {
           calculator = new Calculator();
            palindrome = new PalindromeStr();
        }

        [Test]
        public void Add_Test1()
        {
            int a = 10;
            int b = 20;

            int expected = 30;

            int actual = calculator.Add(a, b);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Sub_Test1()
        {
            int a = 10;
            int b = 2;

            int expected = 8;

            int actual = calculator.Sub(a, b);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Mul_Test1()
        {
            int a = 10;
            int b = 20;

            int expected = 200;

            int actual = calculator.Mul(a, b);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Div_Test1()
        {
            int a = 10;
            int b = 2;

            int expected = 5;

            int actual = calculator.Div(a, b);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Palindrome_Test1()
        {
            string str = "madam";

            bool expected = true;

            bool actual = palindrome.IsPlaindrome(str);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Not_Palindrome_Test1()
        {
            string str = "hello";

            bool expected = false;

            bool actual = palindrome.IsPlaindrome(str);

            Assert.AreEqual(expected, actual);

        }
    }
}