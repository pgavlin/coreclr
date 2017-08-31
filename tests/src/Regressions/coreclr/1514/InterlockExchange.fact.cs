using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    class _1514_InterlockExchange_InterlockExchange_
    {
        [OuterLoop]
        [Fact]
        public void _1514_InterlockExchange_InterlockExchange_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Regressions\\coreclr\\1514\\InterlockExchange\\InterlockExchange.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
