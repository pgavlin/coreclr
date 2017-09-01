using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _regressions_429802_CMain_CMain_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_429802_CMain_CMain_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\429802\\CMain\\CMain.cmd");
        }
    }
}
