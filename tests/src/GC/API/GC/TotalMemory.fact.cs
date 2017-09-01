using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_TotalMemory_TotalMemory_
    {
        [OuterLoop]
        [Fact]
        public void _GC_TotalMemory_TotalMemory_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\TotalMemory\\TotalMemory.cmd");
        }
    }
}
