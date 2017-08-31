using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect1_Collect1_
    {
        [Fact]
        public void _GC_Collect1_Collect1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect1\\Collect1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
