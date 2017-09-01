using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _generics_regressions_123712_repro123712_repro123712_
    {
        [OuterLoop]
        [Fact]
        public void _generics_regressions_123712_repro123712_repro123712_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\generics\\regressions\\123712\\repro123712\\repro123712.cmd");
        }
    }
}
