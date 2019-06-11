using System;
using Xunit;

namespace TeamCityHelloWorldTests
{
    public class ProgamTests
    {
        /// <summary>
        /// Should Return true
        /// </summary>
        [Fact]
        public void Test1()
        {
            var value = true;
            Assert.Equal(value , true);
        }
    }
}
