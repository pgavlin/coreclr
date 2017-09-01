using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_dd116295_dd116295_dd116295_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dd116295_dd116295_dd116295_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dd116295\\dd116295\\dd116295.cmd");
        }
    }
}
