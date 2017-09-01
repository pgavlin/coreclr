using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GCHandle_IsAllocated_IsAllocated_
    {
        [OuterLoop]
        [Fact]
        public void _GCHandle_IsAllocated_IsAllocated_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GCHandle\\IsAllocated\\IsAllocated.cmd");
        }
    }
}
