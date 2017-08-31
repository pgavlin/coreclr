using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _GC_Collect_fail_Collect_fail_
    {
        [Fact]
        public void _GC_Collect_fail_Collect_fail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\GC\\Collect_fail\\Collect_fail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
