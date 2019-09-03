using System;
using Xunit;
using Chuck;
using System.Collections.Generic;

namespace EnsureTests
{
    public class EnsureNotNullTests
    {
        [Fact]
        public void Should_Throw_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Ensure.ArgumentNotNull(null as string, "ArgumentNullException"));
            Assert.Throws<ArgumentNullException>(() => Ensure.ArgumentNotNull(null as long?, "ArgumentNullException"));
            Assert.Throws<ArgumentNullException>(() => Ensure.ArgumentNotNull(null as int?, "ArgumentNullException"));
            Assert.Throws<ArgumentNullException>(() => Ensure.ArgumentNotNull(null as bool?, "ArgumentNullException"));
            Assert.Throws<ArgumentNullException>(() => Ensure.ArgumentNotNull(null as IEnumerable<string>, "ArgumentNullException"));
        }

        [Fact]
        public void Should_Not_Throw_ArgumentNullException()
        {
            Ensure.ArgumentNotNull("Test argument", "ArgumentNullException");
            Ensure.ArgumentNotNull(long.MaxValue, "ArgumentNullException");
            Ensure.ArgumentNotNull(int.MaxValue, "ArgumentNullException");
            Ensure.ArgumentNotNull(true, "ArgumentNullException");
            Ensure.ArgumentNotNull(new List<string>(), "ArgumentNullException");
        }
    }
}