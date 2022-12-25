using Issue1386;
using Xunit;

namespace Issue1386Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(11, new Class1().ReturnEleven());
        }
    }
}