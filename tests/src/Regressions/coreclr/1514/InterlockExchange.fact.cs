using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _1514_InterlockExchange_InterlockExchange_
    {
        [OuterLoop]
        [Fact]
        public void _1514_InterlockExchange_InterlockExchange_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\1514\\InterlockExchange\\InterlockExchange.cmd");
        }
    }
}
