using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    public class _GC_TotalMemory2_TotalMemory2_
    {
        [OuterLoop]
        [Fact]
        public void _GC_TotalMemory2_TotalMemory2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\API\\GC\\TotalMemory2\\TotalMemory2.cmd");
        }
    }
}
