using CoreclrTestLib;
using Xunit;

namespace GC_API
{
    class _WeakReference_multipleWRs_1_multipleWRs_1_
    {
        [Fact]
        public void _WeakReference_multipleWRs_1_multipleWRs_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\API\\WeakReference\\multipleWRs_1\\multipleWRs_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
