using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect0_Collect0_
    {
        [Fact]
        public void _GC_Collect0_Collect0_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect0\\Collect0.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
