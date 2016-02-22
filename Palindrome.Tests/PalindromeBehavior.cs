using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Palindrome.Tests
{
    [TestFixture]
    public class PalindromeBehavior
    {
        [Test]
        public void _should_be_a_palindrome()
        {
            var palindrome = new Core.Palindrome("");
        }
    }
}
