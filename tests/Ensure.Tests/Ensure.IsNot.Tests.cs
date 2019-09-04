using System;
using EnsureDotnet;
using Xunit;

namespace EnsureTests
{
    public class EnsureIsNotTests
    {
        [Fact]
        public void Should_Throw_ArgumentNullException()
        {
            string val = null;
            Assert.Throws<ArgumentNullException>(() => Ensure.IsNot<ArgumentNullException>(string.IsNullOrEmpty(val), "ArgumentNullException"));
        }

        [Fact]
        public void Should_Not_Throw_ArgumentNullException()
        {
            string val = "Aksel Arzuman";
            Ensure.IsNot<ArgumentNullException>(string.IsNullOrEmpty(val), "ArgumentNullException");
        }
    }
}