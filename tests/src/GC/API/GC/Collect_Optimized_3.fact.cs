using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect_Optimized_3_Collect_Optimized_3_
    {
        [Fact]
        public void _GC_Collect_Optimized_3_Collect_Optimized_3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_Optimized_3\\Collect_Optimized_3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
