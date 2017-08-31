using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect_Optimized_2_Collect_Optimized_2_
    {
        [Fact]
        public void _GC_Collect_Optimized_2_Collect_Optimized_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Optimized_2\\Collect_Optimized_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
