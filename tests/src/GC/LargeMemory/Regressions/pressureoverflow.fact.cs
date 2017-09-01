using CoreclrTestLib;
using Xunit;

namespace GC_LargeMemory
{
    public class _Regressions_pressureoverflow_pressureoverflow_
    {
        [Fact]
        public void _Regressions_pressureoverflow_pressureoverflow_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\LargeMemory\\Regressions\\pressureoverflow\\pressureoverflow.cmd");
        }
    }
}
