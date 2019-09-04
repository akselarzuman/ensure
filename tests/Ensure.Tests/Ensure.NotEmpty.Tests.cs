using System;
using Xunit;
using EnsureDotnet;
using System.Collections.Generic;

namespace EnsureTests
{
    public class EnsureNotEmptyTests
    {
        [Fact]
        public void Should_Throw_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Ensure.ArgumentNotNullOrEmptyString(string.Empty, "ArgumentNullException"));
            Assert.Throws<ArgumentException>(() => Ensure.ArgumentNotNullOrEmptyEnumerable(new List<string>(), "ArgumentNullException"));
        }

        [Fact]
        public void Should_Not_Throw_ArgumentException()
        {
            Ensure.ArgumentNotNullOrEmptyString("Test argument", "ArgumentNullException");
            Ensure.ArgumentNotNullOrEmptyEnumerable(new List<string> { "Test argument" }, "ArgumentNullException");
        }
    }
}