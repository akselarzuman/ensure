using System;
using Xunit;
using EnsureDotnet;

namespace EnsureTests
{
    public class EnsureGreaterThanTests
    {
        [Fact]
        public void Should_Throw_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Ensure.GreaterThanZero(0, "ArgumentNullException"));
            Assert.Throws<ArgumentException>(() => Ensure.GreaterThanZero(0.0M, "ArgumentNullException"));
            Assert.Throws<ArgumentException>(() => Ensure.GreaterThanZero(0.0D, "ArgumentNullException"));
            Assert.Throws<ArgumentException>(() => Ensure.GreaterThanZero(0.0F, "ArgumentNullException"));
        }

        [Fact]
        public void Should_Not_Throw_ArgumentException()
        {
            Ensure.GreaterThanZero(10, "ArgumentNullException");
            Ensure.GreaterThanZero(0.1M, "ArgumentNullException");
            Ensure.GreaterThanZero(0.1D, "ArgumentNullException");
            Ensure.GreaterThanZero(0.1F, "ArgumentNullException");
        }
    }
}