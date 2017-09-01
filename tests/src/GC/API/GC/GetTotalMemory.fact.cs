using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_GetTotalMemory_GetTotalMemory_
    {
        [OuterLoop]
        [Fact]
        public void _GC_GetTotalMemory_GetTotalMemory_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\GetTotalMemory\\GetTotalMemory.cmd");
        }
    }
}
