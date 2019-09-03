using System;
using Xunit;
using Chuck;
using System.Collections.Generic;

namespace EnsureTests
{
    public class EnsureNotEmptyTests
    {
        [Fact]
        public void Should_Throw_ArgumentNullException()
        {
            Assert.Throws<ArgumentException>(() => Ensure.ArgumentNotNullOrEmptyString(string.Empty, "ArgumentNullException"));
            Assert.Throws<ArgumentException>(() => Ensure.ArgumentNotNullOrEmptyEnumerable(new List<string>(), "ArgumentNullException"));
        }

        [Fact]
        public void Should_Not_Throw_ArgumentNullException()
        {
            Ensure.ArgumentNotNullOrEmptyString("Test argument", "ArgumentNullException");
            Ensure.ArgumentNotNullOrEmptyEnumerable(new List<string> { "Test argument" }, "ArgumentNullException");
        }
    }
}